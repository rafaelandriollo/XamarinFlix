﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace XamFlix.Droid
{
    [Activity(Theme = "@style/MyTheme.Splash",
    MainLauncher = true,
    NoHistory = true,
    Label = "XamFlix")]
    public class Splash_Screen : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            StartActivity(new Intent(Application.Context, typeof(MainActivity)));
        }
    }
}