using Android.App;
using Xamarin.Forms.Xaml;
using Xamarin.Forms;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
[assembly: Application(UsesCleartextTraffic = true)]
[assembly: UsesPermission(Android.Manifest.Permission.Flashlight)]
[assembly: ExportFont("GeosansLight.ttf")]