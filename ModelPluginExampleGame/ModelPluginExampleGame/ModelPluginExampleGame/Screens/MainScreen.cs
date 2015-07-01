#region Usings

using System;
using System.Collections.Generic;
using System.Text;
using FlatRedBall;
using FlatRedBall.Graphics;
using FlatRedBall.Input;
using FlatRedBall.Instructions;
using FlatRedBall.AI.Pathfinding;
using FlatRedBall.Graphics.Animation;
using FlatRedBall.Graphics.Particle;

using FlatRedBall.Math.Geometry;
using FlatRedBall.Math.Splines;
using Microsoft.Xna.Framework;
using Cursor = FlatRedBall.Gui.Cursor;
using GuiManager = FlatRedBall.Gui.GuiManager;
using FlatRedBall.Localization;

#if FRB_XNA || SILVERLIGHT
using Keys = Microsoft.Xna.Framework.Input.Keys;
using Vector3 = Microsoft.Xna.Framework.Vector3;
using Texture2D = Microsoft.Xna.Framework.Graphics.Texture2D;
#endif
#endregion

namespace ModelPluginExampleGame.Screens
{
	public partial class MainScreen
	{

		void CustomInitialize()
		{
            
		    ModelEntityInstance.RotationYVelocity = .5f;
            Camera.Main.CameraCullMode = CameraCullMode.None;
		    Camera.Main.NearClipPlane = -10000f;
            Camera.Main.BackgroundColor = Color.White;
		    
		}

		void CustomActivity(bool firstTimeCalled)
		{
            FlatRedBall.Debugging.Debugger.Write(ModelEntityInstance);

		}

		void CustomDestroy()
		{


		}

        static void CustomLoadStaticContent(string contentManagerName)
        {


        }

	}
}
