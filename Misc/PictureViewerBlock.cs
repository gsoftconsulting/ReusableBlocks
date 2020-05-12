using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReusableBlocks.Misc
{
    public class PictureViewerBlock
    {
        public void View(string fileName)
        {
            Boolean isSuccess = false;           
            try
            {
                // Open the picture by registered picture viewer directly. It it is much faster than openeing with registered document viewer
                var process = new Process();
                process.StartInfo.FileName = "rundll32.exe";
                process.StartInfo.Arguments = @"C:\WINDOWS\System32\shimgvw.dll,ImageView_Fullscreen " + fileName;
                isSuccess = process.Start();
            }
            catch (Exception ex)
            {

            }
            finally
            {            
                if (!isSuccess)
                {
                    // Open the document in registered program 
                    var starter = new ProcessStarterBlock();
                    starter.Start(fileName);
                }
            }

        }
    }
}
