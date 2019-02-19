using System;
using Android.App;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace MapsExample.Droid
{
    [Application]
    [MetaData("com.google.android.maps.v2.API_KEY",
               Value = key)]
    public class MyApp : Application
    {
        public MyApp(IntPtr javaReference, JniHandleOwnership transfer)
            : base(javaReference, transfer)
        {

        }
    }
}