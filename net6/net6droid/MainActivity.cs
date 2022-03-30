namespace net6droid {

  using Android.App;
  using Android.OS;
  using Android.Widget;


  [Activity(Label = "@string/app_name", MainLauncher = true)]
  public class MainActivity : Activity {
    int count = 1;

    protected override void OnCreate(Bundle savedInstanceState)
    {
      base.OnCreate(savedInstanceState);

      // Set our view from the "main" layout resource
      SetContentView(Resource.Layout.activity_main);

      // Get our button from the layout resource,
      // and attach an event to it
      Button button = FindViewById<Button>(Resource.Id.myButton);

      button.Click += (sender, e) =>
      {
        button.Text = $"{count++} clicks!";
      };
    }
  }
}