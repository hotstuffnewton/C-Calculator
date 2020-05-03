using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;                        // these import certain methods to be used in code program did it all for me
using System.Linq;
using System.Text;
using System.Windows.Forms;
///////////////////////////////////////////////THE IMPORTS///////////////////////////////////////////////////////////////////////

namespace WindowsFormsApplication1 { // name of application chosen in MV c#

public partial class Calculator : Form { // called partial form becuase the rest of the code is hidden in designer.cs
    
public Calculator(){  // title of form1.cs
InitializeComponent();
}

////////////////////////////////////////////THE FORMS//////////////////////////////////////////////////////////////////////

double memoryValue = 0.0;  // used to save numbers within m+ m- mr mc
bool clearDisplay = true;  // clears the display when a certain button is pressed 
bool isFirstValue = true;  // nothing has been typed in, when some has been this will = false
bool isAfterEqual = false; // used to tell the program that = has been pressed and an answer is needed but another number is to be +-/*
double currentAnswer;  // keeps track of current answer before = is pressed
double lastValueEntered; // remembers last value entered
char lastOp; // remembers last +-/* pressed
double polochange; // used to change number to pos or neg

////////////////////////////////////////////THE VARIABLES///////////////////////////////////////////////////////////////////////

private void btnClear_Click(object sender, EventArgs e){  // clear button
txtDisplay.Text = "0"; // window shows a 0
btndp.Enabled = true;  // decimal points renenabled 
clearDisplay = true;   // everything is cleared
isFirstValue = true;   // reset to default
isAfterEqual = false;  // reset to defualt
currentAnswer = 0.0;
lastOp = ' '; // last button pressed was decimal point
}

private void Op_button(){  // used for +-*/
clearDisplay = true;  // clears display
btndp.Enabled = true; // decimal point can now be used again

if(isFirstValue){  // this is the first number entered
   currentAnswer = double.Parse(txtDisplay.Text); // saves number for use later
   isFirstValue = false; // no longer first number entered
}
else{ // number being typed in isnt the first number
    lastValueEntered = double.Parse(txtDisplay.Text); // stores last value entered
    switch (lastOp){ 

            case '+':
            currentAnswer += lastValueEntered; // if + is pressed add to saved number
            break;

            case '-':
            currentAnswer -= lastValueEntered; // if - is pressed takeaway from saved number
            break;

            case '*':
            currentAnswer *= lastValueEntered; // if * is pressed times saved number
            break;

            case '/':
            currentAnswer /= lastValueEntered; // if / is pressed divide saved number
            break;
}}} // end void

private void btn_Click(object sender, EventArgs e){  // buttons from 0-9     
Button button = (Button)sender;  // when any button is pressed 0-9 this bit of code looks for what one was pressed and assigneds "digit" that number
string digit = button.Text;

if (isAfterEqual){
    currentAnswer = 0.0; 
    lastOp = ' '; // last button pressed was decimal point
}
isAfterEqual = false; // use of decimal point now counts under first number

if (clearDisplay){    // this if statement removes the 0 shown already on the screen when another button is pressed
    txtDisplay.Text = digit;
    clearDisplay = false;
}
else if(txtDisplay.Text.Length < 26){  // limits amount of number that can be typed into the window
    txtDisplay.AppendText(digit);
}} // end void

private void btnMadd_Click(object sender, EventArgs e){ // button m+
memoryValue += double.Parse(txtDisplay.Text);  // saves value on screen
} // end void

private void btnMsub_Click(object sender, EventArgs e){ // button m-
memoryValue -= double.Parse(txtDisplay.Text);  // deletes value on screen from value saved 
}// end void

private void btnMclr_Click(object sender, EventArgs e){ // button mc
memoryValue = 0.0;  // clear the saved value and resets to defualt
}// end void

private void btnMrec_Click(object sender, EventArgs e){ // button mr
txtDisplay.Text = memoryValue.ToString();  // shows the saved value on screen
}// end void

private void btndp_Click(object sender, EventArgs e){ // button decimal point
if (isAfterEqual){
    currentAnswer = 0.0; 
    lastOp = ' '; // last button pressed was decimal point
}
isAfterEqual = false; // use of decimal point now counts under first number
if (clearDisplay){  // this if statement removes the 0 show in the window when . is pressed
    txtDisplay.Text = "0";
    clearDisplay = false;
}
else{
     txtDisplay.AppendText(".");
     btndp.Enabled = false;  // stops decimal point button being pressed again
}}// end void

private void btnBksp_Click(object sender, EventArgs e){  // back space button
if (txtDisplay.Text.Length > 1){ // if the window has more than 1 number
    if (txtDisplay.Text.EndsWith(".")){
        btndp.Enabled = true; // if decimal point is removed it is re-enabled 
}
txtDisplay.Text = txtDisplay.Text.Substring(0, txtDisplay.Text.Length - 1); // each press of the button removes one number in teh window 
}
else{
    txtDisplay.Text = "0"; // nothing remains in the window show 0
}}// end void

private void btnAdd_Click(object sender, EventArgs e){ // button +
Op_button(); // do everything within op_button
lastOp = '+'; // button + was last to be pressed
}// end void

private void btnSub_Click(object sender, EventArgs e){ // button -
Op_button();  // do everything within op_button
lastOp = '-'; // button - was last to be pressed
}// end void

private void btnMult_Click(object sender, EventArgs e){ // button multiply
Op_button();  // do everything within op_button
lastOp = '*'; // button * was last to be pressed
}// end void

private void btnDiv_Click(object sender, EventArgs e){ // button divide
Op_button();  // do everything within op_button
lastOp = '/'; // button / was last to be pressed
}// end void

private void btnEquals_Click(object sender, EventArgs e){  // button =
clearDisplay = true; // = has been pressed clear window
btndp.Enabled = true; // decimal point re-enabled 

    lastValueEntered = double.Parse(txtDisplay.Text); // stores last value entered
    switch (lastOp){ 

            case '+':
            currentAnswer += lastValueEntered; // if + is pressed add to saved number
            break;

            case '-':
            currentAnswer -= lastValueEntered; // if - is pressed takeaway from saved number
            break;

            case '*':
            currentAnswer *= lastValueEntered; // if * is pressed times saved number
            break;

            case '/':
            currentAnswer /= lastValueEntered; // if / is pressed divide saved number
            break;
}
txtDisplay.Text = currentAnswer.ToString(); // show answer on screen
isFirstValue = true; // a new eqation can be entered using last answer
} // end void

private void btnSign_Click(object sender, EventArgs e){ // +/- button
polochange = double.Parse(txtDisplay.Text); // stores value under name
currentAnswer = double.Parse(txtDisplay.Text); // stores value under name

if(currentAnswer > 0){ // if pos number in window
   currentAnswer -= polochange * 2; // change pos to negative
}
else if(currentAnswer < 0){ // if negative number in window
        currentAnswer -= polochange * 2; // change to pos
}
txtDisplay.Text = currentAnswer.ToString(); // show the change on screen
polochange = 0.0; // reset the saved number under name 
} // end void
}} // end form
