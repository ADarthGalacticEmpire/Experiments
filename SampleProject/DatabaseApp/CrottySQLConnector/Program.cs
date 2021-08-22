using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrottySQLConnector
{
    static class Program //extends Application
    {
        //private Connetion connect = null;

        //create objects for retrieval by user
        //private CheckBox cbCustid = new CheckBox();

        //where clause for search
        //private TextField tfWhere = new TextField();

        //output
        //private TextArea taResult = new TextArea();

        //search and clear buttons
        //private Button btSearch = new Button("Search");
        //private Button btClear = new Button("Clear");

        //Window for UI
        //GridPane dbSearch = new GridPane();


        //BEGIN NEW
        //Override for C# / Forms equivalent to Stage class.


        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //launch args
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
