﻿using System;

using Xamarin.Forms;

namespace XamarinForms_App
{

	public class App : Application
	{
		public static string folderPath;

		public App ()
		{
			// The root page of your application
			MainPage = new NavigationPage( new MyLoginPage());
			//MainPage = new FootballPlayerListPage();
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}

