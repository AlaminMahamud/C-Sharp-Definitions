public event KeyPressEventHandler KeyPress

// Boolean flag used to determine when a character other than a number is entered
private bool nonNumberEntered = false;

// Handle the keyDown Event to determine the type of character entered into the control
private void textBox1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
{
	// Initializing the flag to false
	nonNumberEntered = false;

	// Determine whether the keyStroke is a number form the top of the Keyboard
	if(e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9) 
	{
		// Determine Whether the keystroke is a number from the Keypad
		if(e.KeyCode < Keys.NumPad0 || e.KeyCode >Keys.NumPad9)
		{
			// Determine whether the keystroke is a backspace
			if(e.KeyCode != Keys.Back)
			{
				// A non-numerical keystroke was pressed
				// set the flag to true and evaluate in KeyPress Events
				nonNumberEntered = true;
			}
		}
	}

	// If 'Shift' Key was pressed. it's not a number
	if(Control.ModifierKeys == Keys.Shift)
	{
		nonNumberEntered = true;
	}
}


// This event occurs when the KeyDown Event and can be used to prevent characters from entering the control
private void textBox1_KeyPress(obeject sender, System.Windows.Forms.KeyPressEventArgs e)
{
	// Check for the flag being set in the keyDown event
	if(nonNumberEntered)
	
{		// Stop the character from being entered into the control sicne it is  non-numerical
		e.Handled = true;
	}
}

