using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms;

namespace jagiyo.Droid
{
    public class BaseDependency : Object
    {
        public Activity GetActivity()
        {
            var activity = (Activity)Forms.Context;
            return activity;
        }
    }
}