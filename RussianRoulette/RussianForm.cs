using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RussianRoulette
{
    public partial class RussianRoulette : Form
    {
        GameLogic obj_Game = new GameLogic();

        public RussianRoulette()
        {
            InitializeComponent();
        }
        private void RussianRoulette_Load(object sender, EventArgs e)
        {
            //code to display image in picture box on form load 
            Assembly myAssembly = Assembly.GetExecutingAssembly();
            Stream myStream = myAssembly.GetManifestResourceStream("RussianRoulette.Resources.open.jpg");
            Bitmap bmp = new Bitmap(myStream);
            PicBox_Gun.Image = bmp;

            //disable spin, shoot and shootaway buttons at form load time
            btn_Spin.Enabled = false; 
            btn_Shoot.Enabled = false;
            btn_ShootAway.Enabled = false;
        }

        private void btn_Load_Click(object sender, EventArgs e)
        {
            obj_Game.Load(); // call Load funtion which is defined in GameLogic class with the help of object.
            
            //code to display image in picture box  
            Assembly myAssembly = Assembly.GetExecutingAssembly();
            Stream myStream = myAssembly.GetManifestResourceStream("RussianRoulette.Resources.load.jpg");
            Bitmap bmp = new Bitmap(myStream);
            PicBox_Gun.Image = bmp;

            btn_Load.Enabled = true;
            //disable Load, shoot and shootaway buttons and enable spin button
            btn_Load.Enabled = false;
            btn_Spin.Enabled = true;
            btn_Shoot.Enabled = false;
            btn_ShootAway.Enabled = false;

        }
        private void btn_Spin_Click(object sender, EventArgs e)
        {
            obj_Game.Spin(); // call spin funtion which is defined in GameLogic class with the help of object.

            //code to display image in picture box  
            Assembly myAssembly = Assembly.GetExecutingAssembly();
            Stream myStream = myAssembly.GetManifestResourceStream("RussianRoulette.Resources.GIF.gif");
            Bitmap bmp = new Bitmap(myStream);
            PicBox_Gun.Image = bmp;

            //code to play sound on button click 
            SoundPlayer audio = new SoundPlayer(RussianRoulette.Properties.Resources.spin); 
            audio.Play();

            //disable Load,spin  buttons  and enable shoot and shootaway buttons
            btn_Load.Enabled = false;
            btn_Spin.Enabled = false;
            btn_Shoot.Enabled = true;
            btn_ShootAway.Enabled = true;
        }
        private void btn_Shoot_Click(object sender, EventArgs e)
        {
            //code to display image in picture box  
            Assembly myAssembly = Assembly.GetExecutingAssembly();
            Stream myStream = myAssembly.GetManifestResourceStream("RussianRoulette.Resources.jn.jpg");
            Bitmap bmp = new Bitmap(myStream);
            PicBox_Gun.Image = bmp;

            //code to play sound on button click 
            SoundPlayer audio = new SoundPlayer(RussianRoulette.Properties.Resources.fire);
            audio.Play();
           
            obj_Game.loss = obj_Game.Shoot();// call shoot funtion which is defined in GameLogic class with the help of object.
            if (obj_Game.loss == true)
            {
                obj_Game.scrore = 0;
                MessageBox.Show("Sorry! you lost the game and your score is " + obj_Game.scrore);
                btn_Shoot.Enabled = false;
                btn_ShootAway.Enabled = false;
            }
            else
            {
                //disable Load,spin  buttons and enable shoot and shootaway buttons
                btn_Load.Enabled = false;
                btn_Spin.Enabled = false;
                btn_Shoot.Enabled = true;
                btn_ShootAway.Enabled = true;
            }
           
        }

        private void btn_ShootAway_Click(object sender, EventArgs e)
        {
            //code to display image in picture box  
            Assembly myAssembly = Assembly.GetExecutingAssembly();
            Stream myStream = myAssembly.GetManifestResourceStream("RussianRoulette.Resources.j3.gif");
            Bitmap bmp = new Bitmap(myStream);
            PicBox_Gun.Image = bmp;


            //code to play sound on button click 
            SoundPlayer audio = new SoundPlayer(RussianRoulette.Properties.Resources.fire);
            audio.Play();
            obj_Game.win = obj_Game.Shoot(); // call sSootAway funtion which is defined in GameLogic class with the help of object.
            if (obj_Game.counter <= 1)
            {
                if (obj_Game.win == true && (obj_Game.counter == 0|| obj_Game.counter == 1))
                {
                    MessageBox.Show("Yay! you win the game and your score is" + obj_Game.scrore);
                    btn_Shoot.Enabled = false;
                    btn_ShootAway.Enabled = false;
                }
                else if (obj_Game.win == false && obj_Game.counter == 0)
                {
                    obj_Game.counter++;
                    obj_Game.scrore = 50;
                }
                else if (obj_Game.win == false && obj_Game.counter == 1)
                {
                    obj_Game.scrore = 0;
                    MessageBox.Show("Sorry! your 2 chances are finished and you lost the game. Your score is " + obj_Game.scrore);
                    btn_Shoot.Enabled = false;
                    btn_ShootAway.Enabled = false;
                }
            }
            
        }
      

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit(); // to close the application
        }
    }
}
