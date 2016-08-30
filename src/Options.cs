﻿using System;
using System.Windows.Forms;

namespace GazeNetClient
{
    public partial class Options : Form
    {
        #region Internal members

        private Pointer iPointer;
        private Processor.TwoLevelLowPassFilter iFilter;
        private AutoStarter iAutoStarter;

        #endregion

        #region Public methods

        public Options()
        {
            InitializeComponent();

            foreach (Pointer.Style pointerStyle in Enum.GetValues(typeof(Pointer.Style)))
            {
                cmbPointerAppearance.Items.Add(pointerStyle);
            }
        }

        public void load(Pointer aPointer, Processor.TwoLevelLowPassFilter aFilter, AutoStarter aAutoStarter)
        {
            iPointer = aPointer;
            iFilter = aFilter;
            iAutoStarter = aAutoStarter;

            iPointer.pushSettings();

            cmbPointerAppearance.SelectedItem = aPointer.Appearance;
            trbPointerOpacity.Value = (int)Math.Round(aPointer.Opacity * 10);
            trbPointerSize.Value = aPointer.Size / 10;
            nudPointerFadingInterval.Value = aPointer.FadingInterval;
            nudPointerNoDataVisibilityDuration.Value = aPointer.NoDataVisibilityInterval;

            nudFilterTLow.Value = aFilter.TLow;
            nudFilterTHigh.Value = aFilter.THigh;
            nudFilterWindowSize.Value = aFilter.WindowSize;
            nudFilterFixationThreshold.Value = aFilter.FixationThreshold;

            chkAutoStarterEnabled.Checked = iAutoStarter.Enabled;
            chkPointerAutoShowOnTrackingStart.Checked = iAutoStarter.ShowPointer;

            txbServerHost.Text = WebSocket.Client.Host;
            nudServerPort.Value = WebSocket.Client.Port;
        }

        public void save(bool aAccept)
        {
            iPointer.popSettings(!aAccept);
            
            if (aAccept)
            {
                iFilter.TLow = (int)nudFilterTLow.Value;
                iFilter.THigh = (int)nudFilterTHigh.Value;
                iFilter.WindowSize = (int)nudFilterWindowSize.Value;
                iFilter.FixationThreshold = (int)nudFilterFixationThreshold.Value;

                iPointer.FadingInterval = (long)nudPointerFadingInterval.Value;
                iPointer.NoDataVisibilityInterval = (long)nudPointerNoDataVisibilityDuration.Value;

                iAutoStarter.Enabled = chkAutoStarterEnabled.Checked;
                iAutoStarter.ShowPointer = chkPointerAutoShowOnTrackingStart.Checked;

                WebSocket.Client.Host = txbServerHost.Text;
                WebSocket.Client.Port = (ushort)nudServerPort.Value;
            }
        }

        #endregion

        #region Event handlers

        private void cmbAppearance_SelectedIndexChanged(object sender, EventArgs e)
        {
            iPointer.Appearance = (Pointer.Style)cmbPointerAppearance.SelectedItem;
        }

        private void trbOpacity_ValueChanged(object sender, EventArgs e)
        {
            lblOpacity.Text = (10 * trbPointerOpacity.Value).ToString() + "%";
            iPointer.Opacity = (double)trbPointerOpacity.Value / 10;
        }

        private void trbSize_ValueChanged(object sender, EventArgs e)
        {
            lblSize.Text = (10 * trbPointerSize.Value).ToString() + " px";
            iPointer.Size = trbPointerSize.Value * 10;
        }

        #endregion
    }
}
