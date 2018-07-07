using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Printing;
using System.Drawing;
using System.IO;

// ************************************************************************************************************************************
// Classe utilitaire d'impression de texte
// Claude Jaspart - DL 2016
// All rights not reserved ;-)
//
// Fonction principale : void printText(String texte)
// Paramètre d'entrée  : string 
// Paramètre de sortie : aucun
// ************************************************************************************************************************************

namespace WindowsFormsApplication1
{
    public class Printer
    {
        #region Champs de la classe
        private const int NLINES = 72; 
        private PrintDocument pd;
        StringReader strReader;
        string page = "";
        private Font font;
        private int height;
        private int width;
        private int currentLine = 0;
        private int totalLines = 0;
        #endregion

        #region Constructeur par défaut
        public Printer()
        {
            pd = new PrintDocument();
            font = new Font("Courier New", 10);
            height = (int)pd.DefaultPageSettings.PrintableArea.Height;
            width = (int)pd.DefaultPageSettings.PrintableArea.Width;
        } 
        #endregion

        #region Fonction principale d'impression : void printPage(texte)
        public void printPage(String onepage)
        {     
            pd.PrintPage += delegate (object senders, PrintPageEventArgs events) { events.Graphics.DrawString(onepage, font, new SolidBrush(Color.Black), new Rectangle(0, 0, width, height)); };

            try
            {                
                pd.Print();               
            }
            catch (Exception)
            { 
                // Do nothing    
            }
        }
        #endregion

        #region Retourne le nombre de lignes dans le texte : int getNumberLines(String texte)
        public int getTotalLines(String texte)
        {
            return (int) (  texte.Length - texte.Replace("\n", "").Length  );
        }
        #endregion

        #region Transforme le texte en pages de 72 lignes pour l'imprimer : void printText(String Texte)
        public void printText(string texte)
        {
            bool isPrinted = false;                         // flag pr savoir si la page a été imprimée (dans le cas < 72 lignes)
            strReader = new StringReader(texte);            // objet lecture de string
            totalLines = getTotalLines(texte);              // nombre total de lignes
            page = "";           

            // Selectionne 72 lignes pr les imprimer
            for (currentLine = 1; currentLine <= totalLines; currentLine++)
            {
                isPrinted = false;
                page += strReader.ReadLine() + Environment.NewLine;

                if (currentLine % NLINES == 0)
                {
                    printPage(page);                    
                    isPrinted = true;
                    page = "";
                }
            }

            // Imprime la dernière page si moins de 72 lignes
            if (!isPrinted)
                printPage(page);
        }
        #endregion
    }
}
