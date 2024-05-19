using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeachersCalendar.Models;

namespace TeachersCalendar.EditForms
{
    public partial class StatsForm : Form
    {
        private readonly List<UniClass> classes;

        public StatsForm(List<UniClass> classes)
        {
            InitializeComponent();
            this.classes = classes;
        }

        private void StatsForm_Paint(object sender, PaintEventArgs e)
        {
            DrawPieChart(e.Graphics);
        }

        private void DrawPieChart(Graphics graphics)
        {
            var classDistribution = classes.GroupBy(c => c.ClassTime.DayIndex)
                                           .Select(g => new { DayIndex = g.Key, Count = g.Count() })
                                           .ToList();

            int chartWidth = 300;
            int chartHeight = 300;
            int chartX = 50;
            int chartY = 50;
            int total = classDistribution.Sum(cd => cd.Count);

            Color[] colors = { Color.Red, Color.Blue, Color.Green, Color.Yellow, Color.Orange };
            Brush[] brushes = colors.Select(c => new SolidBrush(c)).ToArray();

            float startAngle = 0;
            foreach (var item in classDistribution)
            {
                float sweepAngle = item.Count / (float)total * 360;
                graphics.FillPie(brushes[item.DayIndex - 1], chartX, chartY, chartWidth, chartHeight, startAngle, sweepAngle);
                startAngle += sweepAngle;
            }

            Font legendFont = new Font("Arial", 10);
            for (int i = 1; i <= 5; i++)
            {
                string dayName = Enum.GetName(typeof(DayOfWeek), i);
                Brush brush = brushes[i - 1];
                graphics.FillRectangle(brush, chartX + chartWidth + 20, chartY + (i - 1) * 20, 15, 15);
                graphics.DrawString(dayName, legendFont, Brushes.Black, chartX + chartWidth + 40, chartY + (i - 1) * 20);
            }
        }
    }
}
