﻿using System;
using System.Data;
using System.Windows.Forms;

namespace HR_Desktop.Admin
{
    public partial class Clients_Profile_Form : Form
    {
        /*******************************************************************************************************/
        #region SETTINGS

        #endregion SETTINGS
        /*******************************************************************************************************/
        #region PUBLIC VARIABLES

        #endregion PUBLIC VARIABLES
        /*******************************************************************************************************/
        #region PROPERTIES

        #endregion PROPERTIES
        /*******************************************************************************************************/
        #region PRIVATE VARIABLES

        #endregion PRIVATE VARIABLES
        /*******************************************************************************************************/
        #region CONSTRUCTOR METHODS

        public Clients_Profile_Form() : this(null) { }
        public Clients_Profile_Form(Guid? id) { InitializeComponent(); }

        #endregion CONSTRUCTOR METHODS
        /*******************************************************************************************************/
        #region METHODS

        private void setupControls()
        {
            this.ShowIcon = false;
            setupControlsBasedOnRoles();
        }

        private void setupControlsBasedOnRoles()
        {

        }

        private void populateData()
        {
            if (isValidToPopulateData())
            {
            }
        }

        private bool isValidToPopulateData()
        {
            return true;
        }

        private void resetData()
        {

        }

        #endregion METHODS
        /*******************************************************************************************************/
        #region EVENT HANDLERS

        private void Form_Load(object sender, EventArgs e)
        {
            setupControls();
            populateData();
        }

        private void lnk_Edit_WorkshiftTemplates_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void lnk_Edit_Workshifts_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LIBUtil.Util.displayForm(null, new Admin.MasterData_v1_Workshifts_Form());
        }

        #endregion EVENT HANDLERS
        /*******************************************************************************************************/
    }
}
