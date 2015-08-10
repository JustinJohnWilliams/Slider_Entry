# Slider_Entry

When using a Slider and an Entry control in Tandem (binding to the same vm object, and therefore updating one another) the Xamarin.Forms Slider would update the Entry just fine, but Entry input to Slider was not working correctly. If you try to type in "100", the Entry would change itself to "90". Added a custom Slider to keep an Accurate Value.
