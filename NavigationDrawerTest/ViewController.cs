using System;
using CoreGraphics;
using Foundation;
using Syncfusion.SfNavigationDrawer.iOS;
using UIKit;

namespace NavigationDrawerTest
{
	public partial class ViewController : UIViewController
	{
		protected ViewController(IntPtr handle) : base(handle)
		{
			// Note: this .ctor should not contain any initialization logic.
		}

		public override void TouchesBegan(NSSet touches, UIEvent evt)
		{
			base.TouchesBegan(touches, evt);
	
		}

		SFNavigationDrawer navigation = null;
		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			UIView subView = this.View.Subviews[0].Subviews[0];
			subView.RemoveFromSuperview();
			navigation = new SFNavigationDrawer();
			navigation.Frame = new CGRect(0, 0, this.View.Frame.Width, this.View.Frame.Height);
			navigation.DrawerHeaderHeight = 0;
			navigation.DrawerWidth = 100;



			UIView contentView = new UIView(new CGRect(0, 0, this.View.Frame.Width, this.View.Frame.Height));

			contentView.BackgroundColor = UIColor.Purple;

		

			subView.Frame = new CGRect(0, 0, this.View.Frame.Width, this.View.Frame.Height);


		

		


			UIView headerView = new UIView(new CGRect(0, 0, 0, 0));
			UIView HeaderView = new UIView();
			HeaderView.Frame = new CGRect(0, 0, navigation.DrawerWidth, 100);
			HeaderView.BackgroundColor = UIColor.FromRGB(49, 173, 225);
			UILabel usernameLabel = new UILabel();
			usernameLabel.Frame = new CGRect(0, 70, navigation.DrawerWidth, 30);
			usernameLabel.Text = (NSString)"James Pollock";
			usernameLabel.TextColor = UIColor.White;
			usernameLabel.TextAlignment = UITextAlignment.Center;
			HeaderView.AddSubview(usernameLabel);
			UIImageView userImg = new UIImageView();
			userImg.Frame = new CGRect((navigation.DrawerWidth / 2) - 25, 15, 50, 50);
			//userImg.Image = new UIImage("Images/User.png");
			HeaderView.AddSubview(userImg);
			//headerView.AddSubview(HeaderView);

			UIView drawerContentView = new UIView(new CGRect(0, 0, navigation.DrawerWidth, 100));

			UIView centerview = new UIView();
			centerview.Frame = new CGRect(0, 0, navigation.DrawerWidth, 600);

			centerview.BackgroundColor = UIColor.Orange;

			UIButton homeButton11 = new UIButton(new CGRect(0, 0, navigation.DrawerWidth, 25));
			homeButton11.SetTitle("Home", UIControlState.Normal);
			homeButton11.SetTitleColor(UIColor.Black, UIControlState.Normal);
			homeButton11.HorizontalAlignment = UIControlContentHorizontalAlignment.Center;
			homeButton11.Layer.CornerRadius = 0;
			homeButton11.Layer.BorderWidth = 1;
			homeButton11.Layer.BorderColor = UIColor.FromRGB(0, 0, 0).CGColor;
			centerview.AddSubview(homeButton11);

			homeButton11.TouchUpInside += delegate
			{
				Console.WriteLine("Home");
				navigation.ToggleDrawer();
			};

			UIButton profileButton = new UIButton(new CGRect(0, 25, navigation.DrawerWidth, 25));
			profileButton.SetTitle("Profile", UIControlState.Normal);
			profileButton.SetTitleColor(UIColor.Black, UIControlState.Normal);
			profileButton.HorizontalAlignment = UIControlContentHorizontalAlignment.Center;
			profileButton.Layer.CornerRadius = 0;
			profileButton.Layer.BorderWidth = 1;
			profileButton.Layer.BorderColor = UIColor.FromRGB(0, 0, 0).CGColor;
			centerview.AddSubview(profileButton);

			UIButton inboxButton = new UIButton(new CGRect(0, 100, navigation.DrawerWidth, 50));
			inboxButton.SetTitle("Inbox", UIControlState.Normal);
			inboxButton.SetTitleColor(UIColor.Black, UIControlState.Normal);
			inboxButton.HorizontalAlignment = UIControlContentHorizontalAlignment.Center;
			inboxButton.Layer.CornerRadius = 0;
			inboxButton.Layer.BorderWidth = 1;
			inboxButton.Layer.BorderColor = UIColor.FromRGB(0, 0, 0).CGColor;
			//centerview.AddSubview(inboxButton);

			UIButton outboxButton = new UIButton(new CGRect(0, 150, navigation.DrawerWidth, 50));
			outboxButton.SetTitle("Outbox", UIControlState.Normal);
			outboxButton.SetTitleColor(UIColor.Black, UIControlState.Normal);
			outboxButton.HorizontalAlignment = UIControlContentHorizontalAlignment.Center;
			outboxButton.Layer.CornerRadius = 0;
			outboxButton.Layer.BorderWidth = 1;
			outboxButton.Layer.BorderColor = UIColor.FromRGB(0, 0, 0).CGColor;
			//centerview.AddSubview(outboxButton);

			UIButton sentItemsButton = new UIButton(new CGRect(0, 200, navigation.DrawerWidth, 50));
			sentItemsButton.SetTitle("SentItems", UIControlState.Normal);
			sentItemsButton.SetTitleColor(UIColor.Black, UIControlState.Normal);
			sentItemsButton.Layer.CornerRadius = 0;
			sentItemsButton.Layer.BorderWidth = 1;
			sentItemsButton.Layer.BorderColor = UIColor.FromRGB(0, 0, 0).CGColor;
			//centerview.AddSubview(sentItemsButton);

			UIButton trashButton = new UIButton(new CGRect(0, 250, navigation.DrawerWidth, 50));
			trashButton.SetTitle("Trash", UIControlState.Normal);
			trashButton.SetTitleColor(UIColor.Black, UIControlState.Normal);
			trashButton.Layer.CornerRadius = 0;
			trashButton.Layer.BorderWidth = 1;
			trashButton.Layer.BorderColor = UIColor.FromRGB(0, 0, 0).CGColor;
			//centerview.AddSubview(trashButton);
			drawerContentView.AddSubview(centerview);

			navigation.DrawerContentView = drawerContentView;
			navigation.DrawerHeaderView = headerView;

















			contentView.AddSubview(subView);
			navigation.ContentView = contentView;
			this.Add(navigation);
			 //Perform any additional setup after loading the view, typically from a nib.
			clickMe.TouchUpInside += delegate
			{
				Console.WriteLine("hh");
				navigation.ToggleDrawer();
			};
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}
