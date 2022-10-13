namespace MauiApp1;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

        //注册导航路由
        //第一个参数是要注册的 URI 的字符串名称，在本例中解析的名称为 "NotePage"。
        //第二个参数是导航到时 "NotePage" 要加载的页面的类型。
        Routing.RegisterRoute(nameof(Views.NotePage), typeof(Views.NotePage));
    }
}
