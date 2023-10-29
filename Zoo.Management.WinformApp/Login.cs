﻿using Microsoft.EntityFrameworkCore;
using Repositories;
using System;
using System.Collections.Generic;
using System.Data;

namespace Zoo.Management.WinformApp
{
	public partial class Login : Form
	{
		private readonly UserRepository _userRepository;
		public Login()
		{
			_userRepository = new UserRepository();
			InitializeComponent();
		}
		
		private async void BtnLogin_Click(object sender, EventArgs e)
		{
			BtnLogin.Enabled = false;
			var userName = TxtUserName.Text;
			var password = TxtPassword.Text;

			var user = await _userRepository.GetAll()
				.Where(u => u.UserName == userName && u.Password == password)
				.FirstOrDefaultAsync();
			if (user == null)
			{
				MessageBox.Show("The user name or password is not correct!!");
				BtnLogin.Enabled = true;
				return;
			}

			if (user.Role == "Admin") 
			{
				// form tiếp theo
				this.Hide();
			}
		}
	}
}
