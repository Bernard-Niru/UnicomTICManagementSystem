using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using UnicomTICManagementSystem.Controllers;
using UnicomTICManagementSystem.Models;

namespace UnicomTICManagementSystem.Views
{
    public partial class RoomsForm : Form
    {
        private RoomController roomController = new RoomController();
        private int selectedRoomId = -1;
        public RoomsForm()
        {
            InitializeComponent();
            LoadRooms();
            LoadRoomType();
        }
        public void LoadRooms() // Load data from Rooms table to DataGridView
        {
            Rooms_dgv.DataSource = null;
            Rooms_dgv.DataSource = roomController.GetAllRooms();
            Rooms_dgv.ClearSelection();
        }
        private void LoadRoomType() // load Room Types to ComboBox
        {
            RoomType_cbx.DataSource = new List<string> { "Hall", "Lab" };
            RoomType_cbx.SelectedIndex = -1;

        }
        private void ClearForm() 
        {
            Name_txt.Clear();
            RoomType_cbx.SelectedIndex -= 1;
        }

        private void Rooms_dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Rooms_dgv_SelectionChanged(object sender, EventArgs e)
        {

            if (Rooms_dgv.SelectedRows.Count > 0)
            {
                var row = Rooms_dgv.SelectedRows[0];
                var roomView = row.DataBoundItem as Room;

                if (roomView != null)
                {
                    selectedRoomId = roomView.Id;

                    var room = roomController.GetRoomById(selectedRoomId);
                    if (room != null)
                    {
                        Name_txt.Text = room.Name;
                        RoomType_cbx.SelectedItem = room.RoomType;

                    }
                }
            }
            else
            {

                selectedRoomId = -1;
            }

        }

        private void Add_btn_Click(object sender, EventArgs e) // Addding room
        {
            Room room = new Room
            {
                Name = Name_txt.Text.Trim(),
                RoomType = (string)RoomType_cbx.SelectedValue


            };
            roomController.AddRoom(room);
            LoadRooms();
            ClearForm();
            MessageBox.Show("Room Added Successfully");
        }

        private void Back_btn_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }

        private void Delete_btn_Click(object sender, EventArgs e) // Deleting room
        {
            if (selectedRoomId == -1)
            {
                MessageBox.Show("Please select a room to delete");
                return;
            }

            var confirmatiion = MessageBox.Show("Are you sure you want to delete this room?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (confirmatiion == DialogResult.Yes)
            {
                roomController.DeleteRoom(selectedRoomId);
                ClearForm();
                LoadRooms();
                MessageBox.Show("Room Deleted Successfully");
            }
        }

    

    private void Update_btn_Click(object sender, EventArgs e) // Updating room
        {
            {
                if (selectedRoomId == -1)
                {
                    MessageBox.Show("Please select a Room to update.");
                    return;
                }

                var room = new Room
                {
                    Id = selectedRoomId,
                    Name = Name_txt.Text,
                    RoomType = (string)RoomType_cbx.SelectedValue

                };
                roomController.UpdateRoom(room);
                LoadRooms();
                ClearForm();    
                MessageBox.Show("Rooom updated successfully!");

            }
        }

        private void RoomType_cbx_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RoomsForm_Load(object sender, EventArgs e)
        {

        }
    }
}
