using Android.App;
using Android.Content.PM;
using Android.OS;
using Android.Views;

namespace MenuApp
{
    [Activity(Theme = "@style/Maui.SplashTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize | ConfigChanges.Density, ScreenOrientation = ScreenOrientation.Landscape)]
    public class MainActivity : MauiAppCompatActivity
    {

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Change the status bar color //Green
            Window.SetStatusBarColor(Android.Graphics.Color.ParseColor("#1f5514")); // Replace with desired color


            // Make the status bar transparent
            //Window.SetFlags(WindowManagerFlags.LayoutNoLimits, WindowManagerFlags.LayoutNoLimits);
            //Window.SetStatusBarColor(Android.Graphics.Color.Transparent);

        }
    }
}