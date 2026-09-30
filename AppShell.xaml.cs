using DiveHubLogbook.Views;

namespace DiveHubLogbook;

public partial class AppShell : Shell
{
    public AppShell(
        DashboardPage dashboardPage,
        LogbookPage logbookPage,
        AddDivePage addDivePage)
    {
        InitializeComponent();

        var tabBar = new TabBar();

       tabBar.Items.Add(new ShellContent
{
    Title = "Dashboard",
    Icon = "tab_dashboard.svg",
    Route = "Dashboard",
    Content = dashboardPage
});

tabBar.Items.Add(new ShellContent
{
    Title = "Logbook",
    Icon = "tab_logbook.svg",
    Route = "Logbook",
    Content = logbookPage
});

tabBar.Items.Add(new ShellContent
{
    Title = "Add Dive",
    Icon = "tab_add.svg",
    Route = "AddDive",
    Content = addDivePage
});

        Items.Add(tabBar);

        // Bunlar tab değil, alt sayfa olarak açılacak.
        Routing.RegisterRoute(nameof(DiveDetailPage), typeof(DiveDetailPage));
        Routing.RegisterRoute(nameof(EditDivePage), typeof(EditDivePage));
    }
}