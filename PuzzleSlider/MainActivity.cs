using Android.App;
using Android.Widget;
using Android.OS;
using Java.Lang;
using System;
using Android.Content;

namespace PuzzleSlider
{
    [Activity(Label = "Puzzle Slider", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : Activity
    {
        int count = 1;

		Button mEasyButton;
		Button mMediumButton;
		Button mHardButton;
		Button mImpossibleButton;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it - We have 4 buttons
            Button mEasyButton = FindViewById<Button>(Resource.Id.Easy_Button);
            mEasyButton.Click += mEasyButton_Click;

            Button mMediumButton = FindViewById<Button>(Resource.Id.Medium_Button);
			mMediumButton.Click += mMediumButton_Click;

            Button mHardButton = FindViewById<Button>(Resource.Id.Hard_Button);
			mHardButton.Click += mHardButton_Click;

            Button mImpossibleButton = FindViewById<Button>(Resource.Id.Impossible_Button);
			mImpossibleButton.Click += mImpossibleButton_Click;
        }

        //Each button leads to same game view but modifies game board slightly
        void mEasyButton_Click(object sender, EventArgs e) 
        {
            Intent intent = new Intent();
        }

		void mMediumButton_Click(object sender, EventArgs e)
		{
			Intent intent = new Intent();
		}

		void mHardButton_Click(object sender, EventArgs e)
		{
			Intent intent = new Intent();
		}

		void mImpossibleButton_Click(object sender, EventArgs e)
		{
			Intent intent = new Intent();
		}

        public static int DifficultyLevel(Button difficulty) 
        {
			//switch statement for which ever button was tapped
            switch (difficulty.Id)
			{
                case Resource.Id.Easy_Button:
					//Do stuff for item1
                    return 1;
                case Resource.Id.Medium_Button:
					//Do stuff for item2
					return 2;
                case Resource.Id.Hard_Button:
					//Do stuff for item3
					return 3;
                case Resource.Id.Impossible_Button:
					//Do stuff for item3
					return 4;
				default:
					return 0;
			}
        }
    }
}

