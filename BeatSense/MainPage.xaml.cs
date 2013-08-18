using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Input;
using System.Windows.Controls;
using System.Windows.Navigation;
using System.Windows.Threading;
using System.Windows.Controls.Primitives;
using System.Threading.Tasks;
using Microsoft.Phone.Tasks;
using System.Windows.Media;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using BeatSense.Resources;


namespace BeatSense
{
    public partial class MainPage : PhoneApplicationPage
    {

        // Constructor
        public MainPage()
        {
            InitializeComponent();

            // Sample code to localize the ApplicationBar
            //BuildLocalizedApplicationBar();
        }

        int box1 = 0;
        int box2 = 0;
        int box3 = 0;
        int box4 = 0;
        string playone;
        string playtwo;
        string playthree;
        string playfour;
        int i = 0;
        int TileSelect = 0;

        public async void pressButton(object sender, MouseButtonEventArgs e)
        {
            Image img = sender as Image;

            if (null != img)
            {
                img.Opacity = 0.5;
                await Task.Delay(350); 
                img.Opacity = 1;
                if (img.Name == "play")
                {
                    i = 0;
                    playSound();
                }
                else if (img.Name == "stop")
                {
                    i = 1;
                }
                else if (img.Name == "info")
                {
                }
            }
        }

        public async void Instrument(object sender, MouseButtonEventArgs e)
        {
            TextBlock txt = sender as TextBlock;
            txt.Opacity = 0.5;
            await Task.Delay(350);
            txt.Opacity = 1;
 
            if (txt.Name == "snare")
            {
                InstrumentSnareShow();
                box1 = 0;
                box2 = 0;
                box3 = 0;
                box4 = 0;
            }
            else if (txt.Name == "bass")
            {
                InstrumentBassShow();
                box1 = 0;
                box2 = 0;
                box3 = 0;
                box4 = 0;
            }
            else if (txt.Name == "hihat")
            {
                InstrumentHiHatShow();
                box1 = 0;
                box2 = 0;
                box3 = 0;
                box4 = 0;
            }
            else if (txt.Name == "ride")
            {
                InstrumentRideShow();
                box1 = 0;
                box2 = 0;
                box3 = 0;
                box4 = 0;
            }
            else if (txt.Name == "crash")
            {
                InstrumentCrashShow();
                box1 = 0;
                box2 = 0;
                box3 = 0;
                box4 = 0;
            }
            else if (txt.Name == "tom")
            {
                InstrumentTomShow();
                box1 = 0;
                box2 = 0;
                box3 = 0;
                box4 = 0;
            }
        }
        public void InstrumentSnareShow()
        {
            if (Box1.Opacity == 0.125 && box1 == 0)
            {
                onebass.Opacity = 0;
                onehihat.Opacity = 0;
                onetom.Opacity = 0;
                onecrash.Opacity = 0;
                oneride.Opacity = 0;
                onesnare.Opacity = 1;
                box1=1;
                Box1.Opacity = 1;
                playone = "snare";
                TileSelect = 0;
            }
            else if (Box2.Opacity == 0.125 && box2 == 0)
            {
                twobass.Opacity = 0;
                twohihat.Opacity = 0;
                twotom.Opacity = 0;
                twocrash.Opacity = 0;
                tworide.Opacity = 0;
                twosnare.Opacity = 1;
                box2=1;
                Box2.Opacity = 1;
                playtwo = "snare";
                TileSelect = 0;
            }
            else if (Box3.Opacity == 0.125 && box3 == 0)
            {
                threebass.Opacity = 0;
                threehihat.Opacity = 0;
                threetom.Opacity = 0;
                threecrash.Opacity = 0;
                threeride.Opacity = 0;
                threesnare.Opacity = 1;
                box3=1;
                Box3.Opacity = 1;
                playthree = "snare";
                TileSelect = 0;
            }
            else if (Box4.Opacity == 0.125 && box4 == 0)
            {
                fourbass.Opacity = 0;
                fourhihat.Opacity = 0;
                fourtom.Opacity = 0;
                fourcrash.Opacity = 0;
                fourride.Opacity = 0;
                foursnare.Opacity = 1;
                box4=1;
                Box4.Opacity = 1;
                playfour = "snare";
                TileSelect = 0;
            }
        }
        public void InstrumentTomShow()
        {
            if (Box1.Opacity == 0.125 && box1 == 0)
            {

                onebass.Opacity = 0;
                onehihat.Opacity = 0;
                onecrash.Opacity = 0;
                oneride.Opacity = 0;
                onesnare.Opacity = 0;
                onetom.Opacity = 0;
                onetom.Opacity = 1;
                box1=1;
                Box1.Opacity = 1;
                playone = "tom";
                TileSelect = 0;
            }
            else if (Box2.Opacity == 0.125 && box2 == 0)
            {
                twobass.Opacity = 0;
                twohihat.Opacity = 0;
                twocrash.Opacity = 0;
                tworide.Opacity = 0;
                twosnare.Opacity = 0;
                twotom.Opacity = 1;
                box2=1;
                Box2.Opacity = 1;
                playtwo = "two";
                TileSelect = 0;
            }
            else if (Box3.Opacity == 0.125 && box3 == 0)
            {
                threebass.Opacity = 0;
                threehihat.Opacity = 0;
                threecrash.Opacity = 0;
                threeride.Opacity = 0;
                threesnare.Opacity = 0;
                threetom.Opacity = 1;
                box3=1;
                Box3.Opacity = 1;
                playthree = "tom";
                TileSelect = 0;
            }
            else if (Box4.Opacity == 0.125 && box4 == 0)
            {
                fourbass.Opacity = 0;
                fourhihat.Opacity = 0;
                fourcrash.Opacity = 0;
                fourride.Opacity = 0;
                foursnare.Opacity = 0;
                fourtom.Opacity = 1;
                box4=1;
                Box4.Opacity = 1;
                playfour = "tom";
                TileSelect = 0;
            }
        }
        public void InstrumentBassShow()
        {
            if (Box1.Opacity == 0.125 && box1 == 0)
            {

                onebass.Opacity = 0;
                onehihat.Opacity = 0;
                onecrash.Opacity = 0;
                oneride.Opacity = 0;
                onesnare.Opacity = 0;
                onetom.Opacity = 0;
                onebass.Opacity = 1;
                box1=1;
                Box1.Opacity = 1;
                playone = "bass";
                TileSelect = 0;
            }
            else if (Box2.Opacity == 0.125 && box2 == 0)
            {

                twobass.Opacity = 0;
                twohihat.Opacity = 0;
                twocrash.Opacity = 0;
                tworide.Opacity = 0;
                twosnare.Opacity = 0;
                twotom.Opacity = 0;
                twobass.Opacity = 1;
                box2=1;
                Box2.Opacity = 1;
                playtwo = "bass";
                TileSelect = 0;
            }
            else if (Box3.Opacity == 0.125 && box3 == 0)
            {
                threebass.Opacity = 0;
                threehihat.Opacity = 0;
                threecrash.Opacity = 0;
                threeride.Opacity = 0;
                threesnare.Opacity = 0;
                threetom.Opacity = 0;
                threebass.Opacity = 1;
                box3=1;
                Box3.Opacity = 1;
                playthree = "bass";
                TileSelect = 0;
            }
            else if (Box4.Opacity == 0.125 && box4 == 0)
            {
                fourbass.Opacity = 0;
                fourhihat.Opacity = 0;
                fourcrash.Opacity = 0;
                fourride.Opacity = 0;
                foursnare.Opacity = 0;
                fourtom.Opacity = 0;
                fourbass.Opacity = 1;
                box4=1;
                Box4.Opacity = 1;
                playfour = "bass";
                TileSelect = 0;
            }
        }
        public void InstrumentHiHatShow()
        {
            if (Box1.Opacity == 0.125 && box1 == 0)
            {
                onebass.Opacity = 0;
                onehihat.Opacity = 0;
                onecrash.Opacity = 0;
                oneride.Opacity = 0;
                onesnare.Opacity = 0;
                onetom.Opacity = 0;
                
                onehihat.Opacity = 1;
                box1=1;
                Box1.Opacity = 1;
                playone = "hihat";
                TileSelect = 0;
            }
            else if (Box2.Opacity == 0.125 && box2 == 0)
            {

                twobass.Opacity = 0;
                twohihat.Opacity = 0;
                twocrash.Opacity = 0;
                tworide.Opacity = 0;
                twosnare.Opacity = 0;
                twotom.Opacity = 0;
                twohihat.Opacity = 1;
                box2=1;
                Box2.Opacity = 1;
                playtwo = "hihat";
                TileSelect = 0;
            }
            else if (Box3.Opacity == 0.125 && box3 == 0)
            {

                threebass.Opacity = 0;
                threehihat.Opacity = 0;
                threecrash.Opacity = 0;
                threeride.Opacity = 0;
                threesnare.Opacity = 0;
                threetom.Opacity = 0;
                threehihat.Opacity = 1;
                box3=1;
                Box3.Opacity = 1;
                playthree = "hihat";
                TileSelect = 0;
            }
            else if (Box4.Opacity == 0.125 && box4 == 0)
            {
                fourbass.Opacity = 0;
                fourhihat.Opacity = 0;
                fourcrash.Opacity = 0;
                fourride.Opacity = 0;
                foursnare.Opacity = 0;
                fourtom.Opacity = 0;
                fourhihat.Opacity = 1;
                box4=1;
                Box4.Opacity = 1;
                playfour = "hihat";
                TileSelect = 0;
            }
        }
        public void InstrumentCrashShow()
        {
            if (Box1.Opacity == 0.125 && box1 == 0)
            {
                onebass.Opacity = 0;
                onehihat.Opacity = 0;
                onecrash.Opacity = 0;
                oneride.Opacity = 0;
                onesnare.Opacity = 0;
                onetom.Opacity = 0;
                
                onecrash.Opacity = 1;
                box1=1;
                Box1.Opacity = 1;
                playone = "crash";
                TileSelect = 0;
            }
            else if (Box2.Opacity == 0.125 && box2 == 0)
            {

                twobass.Opacity = 0;
                twohihat.Opacity = 0;
                twocrash.Opacity = 0;
                tworide.Opacity = 0;
                twosnare.Opacity = 0;
                twotom.Opacity = 0;
                twocrash.Opacity = 1;
                box2=1;
                Box2.Opacity = 1;
                playtwo = "crash";
                TileSelect = 0;
            }
            else if (Box3.Opacity == 0.125 && box3 == 0)
            {

                threebass.Opacity = 0;
                threehihat.Opacity = 0;
                threecrash.Opacity = 0;
                threeride.Opacity = 0;
                threesnare.Opacity = 0;
                threetom.Opacity = 0;
                threecrash.Opacity = 1;
                box3=1;
                Box3.Opacity = 1;
                playthree = "crash";
                TileSelect = 0;
            }
            else if (Box4.Opacity == 0.125 && box4 == 0)
            {
                fourbass.Opacity = 0;
                fourhihat.Opacity = 0;
                fourcrash.Opacity = 0;
                fourride.Opacity = 0;
                foursnare.Opacity = 0;
                fourtom.Opacity = 0;
                fourcrash.Opacity = 1;
                box4=1;
                Box4.Opacity = 1;
                playfour = "crash";
                TileSelect = 0;
            }
        }
        public void InstrumentRideShow()
        {
            if (Box1.Opacity == 0.125 && box1 == 0)
            {
                onebass.Opacity = 0;
                onehihat.Opacity = 0;
                onecrash.Opacity = 0;
                oneride.Opacity = 0;
                onesnare.Opacity = 0;
                onetom.Opacity = 0;
                
                oneride.Opacity = 1;
                box1=1;
                Box1.Opacity = 1;
                playone = "ride";
                TileSelect = 0;
            }
            else if (Box2.Opacity == 0.125 && box2 == 0)
            {

                twobass.Opacity = 0;
                twohihat.Opacity = 0;
                twocrash.Opacity = 0;
                tworide.Opacity = 0;
                twosnare.Opacity = 0;
                twotom.Opacity = 0;
                tworide.Opacity = 1;
                box2=1;
                Box2.Opacity = 1;
                playtwo = "ride";
                TileSelect = 0;
            }
            else if (Box3.Opacity == 0.125 && box3 == 0)
            {

                threebass.Opacity = 0;
                threehihat.Opacity = 0;
                threecrash.Opacity = 0;
                threeride.Opacity = 0;
                threesnare.Opacity = 0;
                threetom.Opacity = 0;
                threeride.Opacity = 1;
                box3=1;
                Box3.Opacity = 1;
                playthree = "ride";
                TileSelect = 0;
            }
            else if (Box4.Opacity == 0.125 && box4 == 0)
            {
                fourbass.Opacity = 0;
                fourhihat.Opacity = 0;
                fourcrash.Opacity = 0;
                fourride.Opacity = 0;
                foursnare.Opacity = 0;
                fourtom.Opacity = 0;
                fourride.Opacity = 1;
                box4=1;
                Box4.Opacity = 1;
                playfour = "ride";
                TileSelect = 0;
            }
        }
        public void selectTile(object sender, MouseButtonEventArgs e)
        {
            Grid block = sender as Grid;
            if (null != block)
            {
                if (TileSelect == 0)
                {
                    block.Opacity = 0.125;
                    TileSelect = 1;
                }
            }
        }
        public async void free(object sender, MouseButtonEventArgs e)
        {
            trash.Opacity = 0.5;
            await Task.Delay(350);
            trash.Opacity=1;
            onebass.Opacity = 0;
            onehihat.Opacity = 0;
            onecrash.Opacity = 0;
            oneride.Opacity = 0;
            onesnare.Opacity = 0;
            onetom.Opacity = 0;
            twobass.Opacity = 0;
            twohihat.Opacity = 0;
            twocrash.Opacity = 0;
            tworide.Opacity = 0;
            twosnare.Opacity = 0;
            twotom.Opacity = 0;
            threebass.Opacity = 0;
            threehihat.Opacity = 0;
            threecrash.Opacity = 0;
            threeride.Opacity = 0;
            threesnare.Opacity = 0;
            threetom.Opacity = 0;
            fourbass.Opacity = 0;
            fourhihat.Opacity = 0;
            fourcrash.Opacity = 0;
            fourride.Opacity = 0;
            foursnare.Opacity = 0;
            fourtom.Opacity = 0;
            box1 = 0;
            box2 = 0;
            box3 = 0;
            box4 = 0;
        }

        public async void playSound()
        {
            while (i == 0)
            {
                var stream1 = TitleContainer.OpenStream(String.Concat("Resources/audio/", playone, ".wav"));
                SoundEffect effect = SoundEffect.FromStream(stream1);
                FrameworkDispatcher.Update();
                effect.Play();
                await Task.Delay(250);

                var stream2 = TitleContainer.OpenStream(String.Concat("Resources/audio/", playtwo, ".wav"));
                SoundEffect effect2 = SoundEffect.FromStream(stream2);
                FrameworkDispatcher.Update();
                effect2.Play();
                await Task.Delay(250);

                var stream3 = TitleContainer.OpenStream(String.Concat("Resources/audio/", playthree, ".wav"));
                SoundEffect effect3 = SoundEffect.FromStream(stream3);
                FrameworkDispatcher.Update();
                effect3.Play();
                await Task.Delay(250);

                var stream4 = TitleContainer.OpenStream(String.Concat("Resources/audio/", playfour, ".wav"));
                SoundEffect effect4 = SoundEffect.FromStream(stream4);
                FrameworkDispatcher.Update();
                effect4.Play();
                await Task.Delay(250);
            }
        }
        // Sample code for building a localized ApplicationBar
        //private void BuildLocalizedApplicationBar()
        //{
        //    // Set the page's ApplicationBar to a new instance of ApplicationBar.
        //    ApplicationBar = new ApplicationBar();

        //    // Create a new button and set the text value to the localized string from AppResources.
        //    ApplicationBarIconButton appBarButton = new ApplicationBarIconButton(new Uri("/Assets/AppBar/appbar.add.rest.png", UriKind.Relative));
        //    appBarButton.Text = AppResources.AppBarButtonText;
        //    ApplicationBar.Buttons.Add(appBarButton);

        //    // Create a new menu item with the localized string from AppResources.
        //    ApplicationBarMenuItem appBarMenuItem = new ApplicationBarMenuItem(AppResources.AppBarMenuItemText);
        //    ApplicationBar.MenuItems.Add(appBarMenuItem);
        //}
    }
}