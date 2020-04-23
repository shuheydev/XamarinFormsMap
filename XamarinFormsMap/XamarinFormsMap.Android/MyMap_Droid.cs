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
using XamarinFormsMap.Droid;

[assembly: Dependency(typeof(MyMap_Droid))]

namespace XamarinFormsMap.Droid
{
    public interface IMap_Droid
    { }



    public class MyMap_Droid:IMap_Droid
    {

    }
}