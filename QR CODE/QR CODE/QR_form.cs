using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MessagingToolkit.QRCode.Codec;
using MessagingToolkit.QRCode.Codec.Data;
using Gma.QrCodeNet.Encoding;
 using System.IO;
using Microsoft.Ink;
using Gma.QrCodeNet.Encoding.Windows.Render;
using System.Drawing.Drawing2D;

namespace QR_CODE
{
    public partial class QR_form : Form
    {
        public QR_form()
        {
            InitializeComponent();
        }
        private int mouse_pos = 0;
        private bool getSliderBack_flag = false;
    
        private void slide_btn_MouseDown(object sender, MouseEventArgs e)
        {
            mouse_pos = e.Location.X;
            auto_slide.Start();
        } 


        private void slide_btn_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && slide_btn.Left >= 0 && slide_btn.Left <= 40)
            
             slide_btn.Left  += (e.X- mouse_pos);
    
           
       }  

        private void slide_btn_Move(object sender, EventArgs e)
        {
            if (slide_btn.Left < 0)
            {
                slide_btn.Left = 0;

            }
          else if (slide_btn.Left > 40)
            {

                slide_btn.Left = 40;
            } 
            if (slide_btn.Left >=20 )
            {
                slide_btn.Text = "ON";
                slide_btn.ForeColor = Color.Green;
                Encode_text();
            }
            else if (slide_btn.Left<20)
            {
                slide_btn.Text = "OFF";
                slide_btn.ForeColor = Color.Red ;
               getSliderBack_flag = false;
         
            } 


        }
        private Bitmap en_bmp,de_bmp;
        string QR_imgAddress;
      
        private void Encode_text()
        {
            try
            {
var qrEncoder = new QrEncoder(ErrorCorrectionLevel.M);
var qrCode = qrEncoder.Encode(en_txt.Text);
MemoryStream ms = new MemoryStream();
             
var renderer = new GraphicsRenderer(new FixedCodeSize(200, QuietZoneModules.Zero), Brushes.Black, Brushes.White);
renderer.WriteToStream(qrCode.Matrix, ImageFormat.Jpeg,ms);

  en_bmp = new Bitmap(ms);
//bm.Save(Application.StartupPath + "//ss.jpg", ImageFormat.Jpeg);
Qr_img.Image = en_bmp;
getSliderBack_flag = true;
            }
            catch (Exception)
            {
                
              
            }

 
        }

        private void auto_slide_Tick(object sender, EventArgs e)
        {
                    
            if (slide_btn.Left >= 20 && slide_btn.Left <= 40 && !getSliderBack_flag)
            {
                slide_btn.Left+=2;

            }
            else if (slide_btn.Left < 20 && slide_btn.Left >0)
            {
                slide_btn.Left -= 2;
            }
            if (getSliderBack_flag && slide_btn.Left > 0)
            {

               slide_btn.Left -= 2;            
            }
             

        }

        private void Qr_img_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right) {
      
             ContextMenu myContextMenu = new ContextMenu();
             MenuItem menuItem1 = new MenuItem("Save To HardDisk");

                menuItem1.Click += menuItem1_Click;
                myContextMenu.MenuItems.Add(menuItem1);
                Qr_img.ContextMenu = myContextMenu;
   }
        }

        void menuItem1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveimg = new SaveFileDialog();
        //    saveimg.InitialDirectory = Convert.ToString(Environment.SpecialFolder.Desktop);
            saveimg.InitialDirectory = @"C:\Users\ahmed\Desktop\images";
            saveimg.Filter = "jpg|*.jpeg|png|*.png|bmp|*.bmp";
            saveimg.FilterIndex = 1;

            if (saveimg.ShowDialog() == DialogResult.OK)
            {
            en_bmp.Save(saveimg.FileName);
  
            }
        }

        private void radiobox_checkedDetector_Tick(object sender, EventArgs e)
        {
            if (encode_rbtn.Checked) {
                page2.Hide();
             }
            else  if (decode_rbtn.Checked)
            {
                page2.Show();
            }
 
 }

        private void decode_Qr() {

            QRCodeBitmapImage qbm = new QRCodeBitmapImage(de_bmp);
            QRCodeDecoder decodeer = new QRCodeDecoder();
          textBox1.Text= decodeer.Decode(qbm);



         }

        private void Render_img()
        {
       de_bmp =new  Bitmap(QR_imgAddress);
     //create a new Bitmap the size of the new image
       Bitmap target_image = new Bitmap(100, 100);
    //create a new graphic from the Bitmap
       Graphics graphic = Graphics.FromImage((Image)target_image);
    graphic.InterpolationMode = InterpolationMode.HighQualityBicubic;
    //draw the newly resized image
    graphic.DrawImage(de_bmp, 0, 0, 100, 100);
    //dispose and free up the resources
    graphic.Dispose();
    //return the image
    QR_img2.Image = target_image;
  decode_Qr();
    }
        
        private void Choose_btn_Click(object sender, EventArgs e)
        {
        OpenFileDialog theDialog = new OpenFileDialog();
            theDialog.Title = "Choose QR image";
            theDialog.Filter = "jpg|*.jpeg|png|*.png|bmp|*.bmp";
            theDialog.FilterIndex = 1;
            theDialog.InitialDirectory = @"C:\Users\ahmed\Desktop\images";
            if (theDialog.ShowDialog() == DialogResult.OK)
            {
                QR_imgAddress = theDialog.FileName;
                Render_img();

            }
        }

        private void QR_form_Load(object sender, EventArgs e)
        {
            radiobox_checkedDetector.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void SaveButton_Click(System.Object sender,
    System.EventArgs e)
        {

        }

        private void decode_rbtn_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.LinkVisited = true;

            System.Diagnostics.Process.Start("http://www.scannitor.bugs3.com");    
        }


        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel3.LinkVisited = true;

            System.Diagnostics.Process.Start("http://www.scannitor.bugs3.com");    

        }



        public Image value { get; set; }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog qrImg = new SaveFileDialog();
            qrImg.Filter = "PNG|*.PNG|JPG|*.JPG|BMP|*.bmp|GIF|*.gif|jpeg|*.jpeg";
            if (qrImg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Qr_img.Image.Save(qrImg.FileName);
            }
        }
    }
}
