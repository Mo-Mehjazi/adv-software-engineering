using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Test_LISTED.Presentation_Model
{
    /*
     * Manage order and existence from tabs that are visible on the GUI.
     *
     * Public Interfaces: void v_TabControl_ManageTab(Tab struct_ForTab)
     * Input:  Manage tab order.
     * Output: Index and internally ordered tab array.
     */
    public class TabControl
    {
        public String[,] array_TabList = new String[3,10]; /* Class-internal 2D array of integer, contains 2 items per tab and up to 10 tabs */

        /*
         * Create the instance of the tab control.
         *
         * Input:  Nothing.
         * Output: Instance of TabControl, contains methods and empty array_TabList.
         */
        public TabControl()
        {
            /* Init constructor. */
        }

        /*
         * Receive tab GUI element button number information.
         *
         * The method is public.
         *
         * Input:  Tab-Struct as reference.
         * Output: Call method according to information in Tab-Struct. (e.g. if no index then create  new index; if index then restructure element; delete is given by tag in tab-struct)
         */
        public void v_TabControl_ManageTab(Tab struct_ForTab)
        {
            return;
        }

        /*
         * Return tab index as integer count.
         *
         * Input:  Tab-Struct as reference.
         * Output: Shall return the index of the tab in tab array.
         */
        public int i_TabControl_ReturnTabIndex(Tab struct_ForTab)
        {
            return 0;
        }

        /*
         * Set new index for given tab in array. When tab order is restructured from GUI.
         *
         * Input:  Tab-Struct as reference, new index that the user wishes.
         * Output: Tab index is changed, old index is deleted and tab array is restructured.
         */
        public int i_TabControl_SetTabToTabArray(Tab struct_ForTab, int int_TabIndexNew, int int_TabIndexOld)
        {
            return int_TabIndexNew;
        }

        /*
         * Delete tab in array list by given index.
         *
         * Input:  Tab index.
         * Output: Tab index shall be deleted from tab array and tab array shall remain ordered without empty indices.
         */
        public void v_TabControl_DeleteTabFromArray(int int_TabIndex)
        {
            return;
        }

        /*
         * Manage tab array with given tab element.
         *
         * Input:  Tab-Struct as reference to new tab.
         * Output: Tab index shall be inserted into tab array, tab array shall remain ordered by increasing numbers.
         */
        public void v_TabControl_ManageArrayOrder(Tab struct_ForTab)
        {
            return;
        }

        /*
         * Manage tab array with given tab index.
         *
         * Input:  Tab index.
         * Output: Tab index shall be inserted into tab array, tab array shall remain ordered by increasing numbers.
         */
        public void v_TabControl_ManageArrayOrder(int int_TabIndex)
        {
            return;
        }

        /*
         * Create new tab.
         *
         * Input:  Tab-Struct as reference to new tab.
         * Output: Create Index for tab and shall be in tab array.
         */
        public void v_TabControl_CreateNewTab(Tab struct_ForTab)
        {
            return;
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