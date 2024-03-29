﻿namespace MonkeyFinder.Controls;

public class CustomSearchHandler : SearchHandler
{    
  public CustomSearchHandler()
  {
    var viewModel = ServiceProvider.GetService<MonkeysViewModel>();
    viewModel.SetCurrentSearchHandler(this);

    Placeholder = "Search...";
    ShowsResults = false;

    ClearPlaceholderIcon = "scan_icon.png";
    ClearPlaceholderEnabled = true;
    ClearPlaceholderIcon.Parent = Application.Current.MainPage;

    TextColor = Colors.Aqua;
    PlaceholderColor = Colors.Aqua;
  }

  public void SetQuery(string searchText)
  {
    Query = searchText;

    //SearchBoxVisibility = SearchBoxVisibility.Hidden;
    //SearchBoxVisibility = SearchBoxVisibility.Expanded;
  }

  public static IServiceProvider ServiceProvider
    =>
#if WINDOWS
    MauiWinUIApplication.Current.Services;
#elif ANDROID
      MauiApplication.Current.Services;
#elif IOS || MACCATALYST
			MauiUIApplicationDelegate.Current.Services;
#else
    null;
#endif
}
