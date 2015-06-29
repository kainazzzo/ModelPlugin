#if ANDROID || IOS
#define REQUIRES_PRIMARY_THREAD_LOADING
#endif

using Color = Microsoft.Xna.Framework.Color;

// Generated Usings
using ModelPluginExampleGame.Entities;
using FlatRedBall;
using FlatRedBall.Screens;
using System;
using System.Collections.Generic;
using System.Text;

namespace ModelPluginExampleGame.Screens
{
	public partial class GameScreen : FlatRedBall.Screens.Screen
	{
		// Generated Fields
		#if DEBUG
		static bool HasBeenLoadedWithGlobalContentManager = false;
		#endif
		
		private ModelPluginExampleGame.Entities.ModelTest ModelTestInstance;
		private ModelPluginExampleGame.Entities.CameraEntiry CameraEntiryInstance;

		public GameScreen()
			: base("GameScreen")
		{
		}

        public override void Initialize(bool addToManagers)
        {
			// Generated Initialize
			LoadStaticContent(ContentManagerName);
			ModelTestInstance = new ModelPluginExampleGame.Entities.ModelTest(ContentManagerName, false);
			ModelTestInstance.Name = "ModelTestInstance";
			CameraEntiryInstance = new ModelPluginExampleGame.Entities.CameraEntiry(ContentManagerName, false);
			CameraEntiryInstance.Name = "CameraEntiryInstance";
			
			
			PostInitialize();
			base.Initialize(addToManagers);
			if (addToManagers)
			{
				AddToManagers();
			}

        }
        
// Generated AddToManagers
		public override void AddToManagers ()
		{
			ModelTestInstance.AddToManagers(mLayer);
			CameraEntiryInstance.AddToManagers(mLayer);
			base.AddToManagers();
			AddToManagersBottomUp();
			CustomInitialize();
		}


		public override void Activity(bool firstTimeCalled)
		{
			// Generated Activity
			if (!IsPaused)
			{
				
				ModelTestInstance.Activity();
				CameraEntiryInstance.Activity();
			}
			else
			{
			}
			base.Activity(firstTimeCalled);
			if (!IsActivityFinished)
			{
				CustomActivity(firstTimeCalled);
			}


				// After Custom Activity
				
            
		}

		public override void Destroy()
		{
			// Generated Destroy
			
			if (ModelTestInstance != null)
			{
				ModelTestInstance.Destroy();
				ModelTestInstance.Detach();
			}
			if (CameraEntiryInstance != null)
			{
				CameraEntiryInstance.Destroy();
				CameraEntiryInstance.Detach();
			}

			base.Destroy();

			CustomDestroy();

		}

		// Generated Methods
		public virtual void PostInitialize ()
		{
			bool oldShapeManagerSuppressAdd = FlatRedBall.Math.Geometry.ShapeManager.SuppressAddingOnVisibilityTrue;
			FlatRedBall.Math.Geometry.ShapeManager.SuppressAddingOnVisibilityTrue = true;
			FlatRedBall.Math.Geometry.ShapeManager.SuppressAddingOnVisibilityTrue = oldShapeManagerSuppressAdd;
		}
		public virtual void AddToManagersBottomUp ()
		{
			CameraSetup.ResetCamera(SpriteManager.Camera);
			AssignCustomVariables(false);
		}
		public virtual void RemoveFromManagers ()
		{
			ModelTestInstance.RemoveFromManagers();
			CameraEntiryInstance.RemoveFromManagers();
		}
		public virtual void AssignCustomVariables (bool callOnContainedElements)
		{
			if (callOnContainedElements)
			{
				ModelTestInstance.AssignCustomVariables(true);
				CameraEntiryInstance.AssignCustomVariables(true);
			}
		}
		public virtual void ConvertToManuallyUpdated ()
		{
			ModelTestInstance.ConvertToManuallyUpdated();
			CameraEntiryInstance.ConvertToManuallyUpdated();
		}
		public static void LoadStaticContent (string contentManagerName)
		{
			if (string.IsNullOrEmpty(contentManagerName))
			{
				throw new System.ArgumentException("contentManagerName cannot be empty or null");
			}
			#if DEBUG
			if (contentManagerName == FlatRedBall.FlatRedBallServices.GlobalContentManager)
			{
				HasBeenLoadedWithGlobalContentManager = true;
			}
			else if (HasBeenLoadedWithGlobalContentManager)
			{
				throw new System.Exception("This type has been loaded with a Global content manager, then loaded with a non-global.  This can lead to a lot of bugs");
			}
			#endif
			ModelPluginExampleGame.Entities.ModelTest.LoadStaticContent(contentManagerName);
			ModelPluginExampleGame.Entities.CameraEntiry.LoadStaticContent(contentManagerName);
			CustomLoadStaticContent(contentManagerName);
		}
		[System.Obsolete("Use GetFile instead")]
		public static object GetStaticMember (string memberName)
		{
			return null;
		}
		public static object GetFile (string memberName)
		{
			return null;
		}
		object GetMember (string memberName)
		{
			return null;
		}


	}
}
