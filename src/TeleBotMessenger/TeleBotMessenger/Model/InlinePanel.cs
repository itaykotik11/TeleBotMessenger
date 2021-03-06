﻿using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using TeleBotMessenger.Properties;

namespace TeleBotMessenger.Model
{
    public class InlinePanel : Panel
    {
        private Control _parent;
        private readonly Button _addButton;
        private readonly Button _delButton;
        private const int ButtonSpaces = 5;
        public List<InlineButton> Buttons { get; set; } = new List<InlineButton>();

        public InlinePanel(int width, Control parent)
        {
            _parent = parent;
            Size = new Size(width, 38);
            // 
            // btnAddColumn
            // 
            _addButton = new Button
            {
                BackgroundImage = Resources.plus,
                BackgroundImageLayout = ImageLayout.Zoom,
                Cursor = Cursors.Hand,
                FlatStyle = FlatStyle.Flat,
                Location = new Point(0, 9),
                Size = new Size(20, 20)
            };
            _addButton.Click += (s, e) => Add();
            // 
            // btnAddColumn
            // 
            _delButton = new Button
            {
                BackgroundImage = Resources.negative,
                BackgroundImageLayout = ImageLayout.Zoom,
                Cursor = Cursors.Hand,
                FlatStyle = FlatStyle.Flat,
                Location = new Point(24, 9),
                Size = new Size(20, 20)
            };
            _delButton.Click += (s, e) => Del();
            //
            // Add first button
            //
            _addButton.PerformClick();
        }

        public void Del()
        {
            var lastBtn = Buttons.LastOrDefault();
            if (Buttons.Count > 1)
            {
                Buttons.Remove(lastBtn);
                OrderColumns();
            }
            else // last button just remained
            {
                Buttons.Remove(lastBtn);
                Controls.Clear();
                Dispose();
            }
        }

        public void Add()
        {
            Add(new InlineButton(_parent));
        }

        public void Add(InlineButton btn)
        {
            Buttons.Add(btn);
            OrderColumns();
        }

        public void OrderColumns()
        {
            Controls.Clear();
            var initX = _delButton.Location.X + _delButton.Width + ButtonSpaces;
            Controls.Add(_addButton);
            Controls.Add(_delButton);

            var w = ((Size.Width - initX) / Buttons.Count) - ButtonSpaces;
            var h = Size.Height - 8;
            for (var i = 0; i < Buttons.Count; i++)
            {
                var button = Buttons[i];
                button.Size = new Size(w, h);
                button.Location = new Point(initX + (i * (ButtonSpaces + w)), 4);
                Controls.Add(button);
            }
        }

    }
}