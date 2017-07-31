
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

namespace PuzzleSlider
{
    [Activity(Label = "GameActivity")]
    public class GameActivity : Activity
    {

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.Game);
			//Make sure it is android resource and use .axml
			//https://www.youtube.com/watch?v=EAr098PHt3w
            //good tutorials

			// Create your application here
		
        }
    }
}
