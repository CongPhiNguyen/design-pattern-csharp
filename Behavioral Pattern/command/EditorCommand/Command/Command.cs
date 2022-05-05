﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EditorCommand
{
    public abstract class Command
    {
        protected Editor editor;

        public Command(Editor editor)
        {
            this.editor = editor;
        }
        public abstract void Execute(Content content);
    }
}
