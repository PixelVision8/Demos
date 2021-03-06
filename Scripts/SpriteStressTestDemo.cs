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

using PixelVisionSDK.Chips;
using PixelVisionSDK.Utils;

//
// The Stress Test Demo highlights the sprite rendering limitation of Pixel Vision 8. By default,
// the DisplayChip can only handle displaying 64 sprites at the same time. We'll create a loop the
// attempts to render more sprite than the system can handle. The outcome is that additional draw
// calls are ignored and the engine maintains its optimal performance.
//

/// <image name="image name">
///     PATH TO AN IMAGE
/// </image>
/// <summary>
///     We are going to extend the GameChip class and override its Update() and Draw() methods. For this
///     demo we won't need Init() so it can be ignored.
/// </summary>
public class SpriteStressTestDemo : GameChip
{

    private readonly float delayTime = 2;
    private readonly int totalSprites = 1000;

    // These are some fields we'll use for performing the stress test.
    private float delay;

    /// <summary>
    ///     The Update() method is part of the game's life cycle. The engine calls Update() on every frame before
    ///     the Draw() method. It accepts one argument, timeDelta, which is the difference in milliseconds since
    ///     the last frame. We are going to use this timeDelta value to keep track of the time before changing
    ///     the background color.
    /// </summary>
//    public override void Update(float timeDelta)
//    {
//
//        // We start by adding the time delta to the delay.
//        delay += timeDelta;
//
//        // Next, we will need to test if the delay value is greater than the delayTime field we set up at the 
//        // beginning of our class.
//        if (delay > delayTime)
//        {
//
//            // After the appropriate delay, we can change the background color a random value. We'll cap this 
//            // between 0 and 63.
//            apiBridge.ChangeBackgroundColor(MathUtil.RandomRange(0, 63));
//
//            // We need to reset the delay so we can start tracking it again on the next frame.
//            delay = 0;
//
//        }
//
//    }
//
//    /// <summary>
//    ///     The Draw() method is part of the game's life cycle. It is called after Update() and
//    ///     is where all of our draw calls should go. We'll be using this to render sprites to the display.
//    /// </summary>
//    public override void Draw()
//    {
//
//        // Clearing the display on each frame is important. Since we are not using the ScreenBufferChip, 
//        // we can directly clear the DisplayChip by calling the Clear() method.
//        apiBridge.Clear();
//
//        // This loop will create a random x and y value based on the display's dimension then attempt to 
//        // draw a sprite.
//        for (var i = 0; i < totalSprites; i++)
//        {
//            var x = MathUtil.RandomRange(0, apiBridge.displayWidth);
//            var y = MathUtil.RandomRange(0, apiBridge.displayHeight);
//            apiBridge.DrawSprite(i + 12, x, y, false, false, true, 0);
//        }
//
//    }

}