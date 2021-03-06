﻿//  
// Copyright (c) Jesse Freeman. All rights reserved.  
// 
// Licensed under the Microsoft Public License (MS-PL) License. 
// See LICENSE file in the project root for full license information. 
// 
// Contributors
// --------------------------------------------------------
// This is the official list of Pixel Vision 8 contributors:
//  
// Jesse Freeman - @JesseFreeman
// Christer Kaitila - @McFunkypants
// Pedro Medeiros - @saint11
// Shawn Rakowski - @shwany
// 

using PixelVisionSDK;
using PixelVisionSDK.Chips;

// This demo assumes you have implemented your input solution to capture keyboard input by
// extending the ButtonState class and registering it with the ControllerChip.You can see
// an example of this in the Unity Runner project. Once implemented, you can capture input
// and display it in your game.

/// <summary>
///     We are going to extend the GameChip class and override its Init(), Update() and Draw() methods.
/// </summary>
public class ControllerDemo : GameChip
{

    // Before we can display the input, we'll want to track each button state. These Boolean Arrays will 
    // help us track if each button is down (false) or up (true).
    private readonly bool[] player1States = new bool[8];
    private readonly bool[] player2States = new bool[8];

    // We'll use these values to help lay out the button state text.
    private readonly Vector pos = new Vector(1, 7);

    // Pixel Vision 8 supports 8 unique buttons: Up, Down, Left, Right, A, B, Select and Start.
    private readonly int totalButtons = 8;
    private readonly int xOffset = 10;

    /// <summary>
    ///     The Init() method is part of the game's lifecycle and called a game starts. We are going to
    ///     use this method to configure background color, ScreenBufferChip and draw some text to the display.
    /// </summary>
//    public override void Init()
//    {
//
//        // Before we start, we need to set a background color and rebuild the ScreenBufferChip. The screen buffer 
//        // allows us to draw our fonts into the background layer to save on draw calls.
//        apiBridge.ChangeBackgroundColor(32);
//        apiBridge.RebuildScreenBuffer();
//
//        // We need to display some default text for our demo explaining what is going on. This text will just be 
//        // drawn into the screen buffer.
//        apiBridge.DrawFontToBuffer("CONTROLLER TEST", pos.x, pos.y - 2, "large-font", 0);
//        var text = "    UP:\n  DOWN:\n RIGHT:\n  LEFT:\n     A:\n     B:\nSELECT:\n START:\n";
//        apiBridge.DrawFontToBuffer("PLAYER ONE\n" + text, pos.x, pos.y, "small-font", -4);
//        apiBridge.DrawFontToBuffer("PLAYER TWO\n" + text, pos.x + xOffset, pos.y, "small-font", -4);
//
//    }
//
//    /// <summary>
//    ///     The Update() method is part of the game's life cycle. The engine
//    ///     calls Update() on every frame before the Draw() method. It accepts
//    ///     one argument, timeDelta, which is the difference in milliseconds
//    ///     since the last frame. We are going to track each player's button state.
//    /// </summary>
//    public override void Update(float timeDelta)
//    {
//
//        // We'll need to loop through each of the buttons. We can use the totalButtons to limit the for loop and 
//        // we'll move through each controller's button states at the same time.
//        for (var i = 0; i < totalButtons; i++)
//        {
//
//            // The ButtonDown() method returns true when a button is down and false if the player is not pressing it. 
//            // We'll save this value into our player1States and player2States Arrays.
//            player1States[i] = apiBridge.ButtonDown(i, 0);
//            player2States[i] = apiBridge.ButtonDown(i, 1);
//
//        }
//
//    }
//
//    /// <summary>
//    ///     The Draw() method is part of the game's life cycle. It is called after Update() and
//    ///     is where all of our draw calls should go. We'll be using this to render font characters to the display.
//    /// </summary>
//    public override void Draw()
//    {
//
//        // It's important to clear the display on each frame. There are two ways to do this. Here 
//        // we are going to use the DrawScreenBuffer() way to copy over the existing buffer and clear
//        // all of the previous pixel data.
//        apiBridge.DrawScreenBuffer();
//
//        // This resets the x and y values we use to draw the fonts to the display.
//        var x = 0;
//        var y = 0;
//
//        // In this loop, we set up the X and Y positions for our text then draw the font to the display to show the 
//        // current state of each button.
//        for (var i = 0; i < totalButtons; i++)
//        {
//            x = (pos.x + 8) * 4;
//            y = (i + pos.y) * 8 + pos.y;
//            apiBridge.DrawFont(player1States[i] ? "1" : "0", x, y + 1, "small-font", -4);
//        }
//
//        // We'll do the same thing for player two but adjust for the text being in the second column by adding the xOffset the x value.
//        for (var i = 0; i < totalButtons; i++)
//        {
//            x = (pos.x + xOffset * 2 + 8) * 4;
//            y = (i + pos.y) * 8 + pos.y;
//            apiBridge.DrawFont(player2States[i] ? "1" : "0", x, y + 1, "small-font", -4);
//        }
//
//    }

}