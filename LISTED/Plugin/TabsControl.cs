using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LISTED.Plugin
{
    /*
     * Manage order and existence from tabs that are visible on the GUI.
     *
     * Public Interfaces: void v_TabControl_ManageTab(Tab struct_ForTab)
     * Input:  Manage tab order.
     * Output: Index and internally ordered tab array.
     */
    public class TabsControl
    {
        public String[,] array_TabList = new String[3,10]; /* Class-internal 2D array of integer, contains 2 items per tab and up to 10 tabs */

        /*
         * Create the instance of the tab control.
         *
         * Input:  Nothing.
         * Output: Instance of TabControl, contains methods and empty array_TabList.
         */
        public TabsControl()
        {
            /* Init constructor. */
        }

        /*
         * Create new tab.
         *
         * Input:  Tab-Struct as reference to new tab.
         * Output: Create Index for tab and shall be in tab array.
         */
        public void v_TabControl_CreateNewTab(TabPage TabToCreate,string TabName)
        {
            TabToCreate.Text = TabName;
        }

    }

    /*
     * Create tab struct to tab elements.
     *
     * Public Interface: Tab(Button button_ForTab)
     * Input:  Button as reference for tab in GUI.
     * Output: Tab-Struct with all important information.
     */
    public class Tab
    {
        /*
         * Create the struct with the necessary information.
         *
         * Input is the GUI element.
         *
         * Input:  Button GUI element indicates tab.
         * Output: Information is in struct, shall be in array list.
         */
        public Tab(Button button_ForTab)
        {
            int int_ArrayTabFieldNumber = 0; /* 0 = not in tab array yet, != 0 order in tab array */
            int int_ButtonVisble = 1; /* 1 = visible, 0 = unvisible */
            String string_ListParametersInStorage = ""; /* Path to storage of list parameters */
            int int_ButtonReference = 0; /* TODO: Button Reference from given button element */
        }
    }
}