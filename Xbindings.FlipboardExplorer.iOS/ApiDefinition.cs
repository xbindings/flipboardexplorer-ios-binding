using System;
using Foundation;
using UIKit;

namespace FlipboardExplorer
{
	// @interface FLEXManager
    [BaseType(typeof(NSObject))]
	interface FLEXManager
	{
		// +(instancetype)sharedManager;
		[Static]
        [Export("sharedManager")]
        FLEXManager SharedManager { get; }

		// @property (readonly, nonatomic) int isHidden;
		[Export ("isHidden")]
		int IsHidden { get; }

		// -(void)showExplorer;
		[Export ("showExplorer")]
		void ShowExplorer ();

		// -(void)hideExplorer;
		[Export ("hideExplorer")]
		void HideExplorer ();

		// -(void)toggleExplorer;
		[Export ("toggleExplorer")]
		void ToggleExplorer ();

		// @property (getter = isNetworkDebuggingEnabled, assign, nonatomic) int networkDebuggingEnabled;
		[Export ("networkDebuggingEnabled")]
		bool NetworkDebuggingEnabled { [Bind ("isNetworkDebuggingEnabled")] get; set; }

		// @property (assign, nonatomic) int networkResponseCacheByteLimit;
		[Export ("networkResponseCacheByteLimit")]
		int NetworkResponseCacheByteLimit { get; set; }

		// @property (assign, nonatomic) int simulatorShortcutsEnabled;
		[Export ("simulatorShortcutsEnabled")]
        bool SimulatorShortcutsEnabled { get; set; }

        // - (void)registerSimulatorShortcutWithKey:(NSString *)key modifiers:(UIKeyModifierFlags)modifiers action:(dispatch_block_t)action description:(NSString *)description;
		[Export ("registerSimulatorShortcutWithKey:modifiers:action:description:")]
        void RegisterSimulatorShortcutWithKey (string key, UIKeyModifierFlags modifiers, Action action, string description);

		// -(void)registerGlobalEntryWithName:(id)entryName objectFutureBlock:(id (^)(void))objectFutureBlock;
		[Export ("registerGlobalEntryWithName:objectFutureBlock:")]
        void RegisterGlobalEntryWithName (string entryName, Func<NSObject> objectFutureBlock);

        //- (void) registerGlobalEntryWithName:(NSString*) entryName viewControllerFutureBlock:(UIViewController* (^)(void))viewControllerFutureBlock;
		[Export ("registerGlobalEntryWithName:viewControllerFutureBlock:")]
        void RegisterGlobalEntryWithName (string entryName, Func<UIViewController> viewControllerFutureBlock);
	}
}
