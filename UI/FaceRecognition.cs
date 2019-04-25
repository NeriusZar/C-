using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Microsoft.ProjectOxford.Face;
using Microsoft.ProjectOxford.Face.Contract;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

public struct apiInfo
{
    public String apiKey, apiLoc;

    public apiInfo(String s1, String s2)
    {
        apiKey = s1;
        apiLoc = s2;
    }
}
namespace UI
{
    class FaceRecognition
    {
        apiInfo apiInformation = new apiInfo();
        ReadFiles nReader = new ReadFiles();
        private FaceServiceClient faceServiceClient;
        
        public void getInformation()
        {
            String file = @"..\Debug\key.txt";
            String path = Path.GetFullPath(file);
            nReader.ReadKeyFile(ref apiInformation, path);
            faceServiceClient = new FaceServiceClient(apiInformation.apiKey,apiInformation.apiLoc);
        }
        
        public async void GetNewImage(String imagePath, PictureBox imgBox)
         {
            string toshow = "";
            Face[] faces = await UploadAndDetectFaces(imagePath); 
  
            if (faces.Length > 0) 
             { 
                var faceBitmap = new Bitmap(imgBox.Image); 
  
                using (var g = Graphics.FromImage(faceBitmap)) 
                { 
                    // Alpha-black rectangle on entire image 
                    g.FillRectangle(new SolidBrush(Color.FromArgb(200, 0, 0, 0)), g.ClipBounds); 
  
                    var br = new SolidBrush(Color.FromArgb(200, Color.LightGreen)); 
  
                    // Loop each face recognized 
                    foreach (var face in faces) 
                    { 
                        var fr = face.FaceRectangle; 
                        var fa = face.FaceAttributes; 
                        // Get original face image (color) to overlap the grayed image 
                        var faceRect = new Rectangle(fr.Left, fr.Top, fr.Width, fr.Height); 
                        g.DrawImage(imgBox.Image, faceRect, faceRect, GraphicsUnit.Pixel); 
                        g.DrawRectangle(Pens.LightGreen, faceRect); 
  
                        // Loop face.FaceLandmarks properties for drawing landmark spots 
                        var pts = new List<Point>(); 
                        Type type = face.FaceLandmarks.GetType(); 
                        foreach (PropertyInfo property in type.GetProperties()) 
                        { 
                            g.DrawRectangle(Pens.LightGreen, GetRectangle((FeatureCoordinate)property.GetValue(face.FaceLandmarks, null))); 
                        } 
  
                        // Calculate where to position the detail rectangle 
                        int rectTop = fr.Top + fr.Height + 10; 
                        if (rectTop + 45 > faceBitmap.Height) rectTop = fr.Top - 30; 
  
                        // Draw detail rectangle and write face informations                      
                        g.FillRectangle(br, fr.Left - 10, rectTop, fr.Width < 120 ? 120 : fr.Width + 20, 25); 
                        g.DrawString(string.Format("{0:0.0} / {1} / {2}", fa.Age, fa.Gender, fa.Emotion.ToRankedList().OrderByDescending(x => x.Value).First().Key), 
                                     new Font("Tahoma",12),Brushes.Black, 
                                     fr.Left - 8, 
                                     rectTop + 4); 
                        toshow = string.Format("{0:0.0} / {1} / {2}", fa.Age, fa.Gender, fa.Emotion.ToRankedList().OrderByDescending(x => x.Value).First().Key);                                    
                    } 
                } 
                MessageBox.Show(toshow);
                imgBox.Image = faceBitmap; 
            } 
         }
        
        private Rectangle GetRectangle(FeatureCoordinate fl) 
        { 
            return new Rectangle((int)fl.X - 1, (int)fl.Y - 1, 2, 2); 
        }

         private async Task<Face[]> UploadAndDetectFaces(string imageFilePath)
        {
            try
            {
                using (Stream imageFileStream = File.OpenRead(imageFilePath))
                {
                    var faces = await faceServiceClient.DetectAsync(imageFileStream,
                        true,
                        true,
                        new FaceAttributeType[] {
                    FaceAttributeType.Gender,
                    FaceAttributeType.Age,
                    FaceAttributeType.Emotion
                        });
                    return faces.ToArray();
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                return new Face[0];
            }
        }
    }
}
