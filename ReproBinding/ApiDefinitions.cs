using System;

using UIKit;
using Foundation;
using ObjCRuntime;
using CoreGraphics;

namespace ReproBinding
{
    // The first step to creating a binding is to add your native library ("libNativeLibrary.a")
    // to the project by right-clicking (or Control-clicking) the folder containing this source
    // file and clicking "Add files..." and then simply select the native library (or libraries)
    // that you want to bind.
    //
    // When you do that, you'll notice that MonoDevelop generates a code-behind file for each
    // native library which will contain a [LinkWith] attribute. MonoDevelop auto-detects the
    // architectures that the native library supports and fills in that information for you,
    // however, it cannot auto-detect any Frameworks or other system libraries that the
    // native library may depend on, so you'll need to fill in that information yourself.
    //
    // Once you've done that, you're ready to move on to binding the API...
    //
    //
    // Here is where you'd define your API definition for the native Objective-C library.
    //
    // For example, to bind the following Objective-C class:
    //
    //     @interface Widget : NSObject {
    //     }
    //
    // The C# binding would look like this:
    //
    //     [BaseType (typeof (NSObject))]
    //     interface Widget {
    //     }
    //
    // To bind Objective-C properties, such as:
    //
    //     @property (nonatomic, readwrite, assign) CGPoint center;
    //
    // You would add a property definition in the C# interface like so:
    //
    //     [Export ("center")]
    //     CGPoint Center { get; set; }
    //
    // To bind an Objective-C method, such as:
    //
    //     -(void) doSomething:(NSObject *)object atIndex:(NSInteger)index;
    //
    // You would add a method definition to the C# interface like so:
    //
    //     [Export ("doSomething:atIndex:")]
    //     void DoSomething (NSObject object, int index);
    //
    // Objective-C "constructors" such as:
    //
    //     -(id)initWithElmo:(ElmoMuppet *)elmo;
    //
    // Can be bound as:
    //
    //     [Export ("initWithElmo:")]
    //     IntPtr Constructor (ElmoMuppet elmo);
    //
    // For more information, see http://developer.xamarin.com/guides/ios/advanced_topics/binding_objective-c/
    //

    partial interface Constants
    {
        // extern double ReproVersionNumber;
        [Field ("ReproVersionNumber")]
        double ReproVersionNumber { get; }

        // extern const unsigned char [] ReproVersionString;
        [Field ("ReproVersionString")]
        byte[] ReproVersionString { get; }
    }

    // @interface Repro : NSObject
    [BaseType (typeof(NSObject))]
    interface Repro
    {
        // +(void)setup:(NSString *)token;
        [Static]
        [Export ("setup:")]
        void Setup (string token);

        // +(void)startRecording;
        [Static]
        [Export ("startRecording")]
        void StartRecording ();

        // +(void)stopRecording;
        [Static]
        [Export ("stopRecording")]
        void StopRecording ();

        // +(void)pauseRecording;
        [Static]
        [Export ("pauseRecording")]
        void PauseRecording ();

        // +(void)resumeRecording;
        [Static]
        [Export ("resumeRecording")]
        void ResumeRecording ();

        // +(void)mask:(UIView *)view;
        [Static]
        [Export ("mask:")]
        void Mask (UIView view);

        // +(void)unmask:(UIView *)view;
        [Static]
        [Export ("unmask:")]
        void Unmask (UIView view);

        // +(void)maskWithRect:(CGRect)rect key:(NSString *)key;
        [Static]
        [Export ("maskWithRect:key:")]
        void MaskWithRect (CGRect rect, string key);

        // +(void)unmaskForKey:(NSString *)key;
        [Static]
        [Export ("unmaskForKey:")]
        void UnmaskForKey (string key);

        // +(void)setUserID:(NSString *)userID;
        [Static]
        [Export ("setUserID:")]
        void SetUserID (string userID);

        // +(void)track:(NSString *)name properties:(NSDictionary *)properties;
        [Static]
        [Export ("track:properties:")]
        void Track (string name, NSDictionary properties);

        // +(void)startWebViewTracking:(id)delegate;
        [Static]
        [Export ("startWebViewTracking:")]
        void StartWebViewTracking (NSObject @id);

        // +(void)enableCrashReporting;
        [Static]
        [Export ("enableCrashReporting")]
        void EnableCrashReporting ();

        // +(void)survey:(NSError **)error;
        [Static]
        [Export ("survey:")]
        void Survey (out NSError error);

        // +(void)enableUsabilityTesting;
        [Static]
        [Export ("enableUsabilityTesting")]
        void EnableUsabilityTesting ();

        // +(void)setLogLevel:(RPRLogLevel)level;
        [Static]
        [Export ("setLogLevel:")]
        void SetLogLevel (RPRLogLevel level);

        // +(void)setPushDeviceToken:(NSData *)pushDeviceToken;
        [Static]
        [Export ("setPushDeviceToken:")]
        void SetPushDeviceToken (NSData pushDeviceToken);

        // +(void)setPushDeviceTokenString:(NSString *)pushDeviceToken;
        [Static]
        [Export ("setPushDeviceTokenString:")]
        void SetPushDeviceTokenString (string pushDeviceToken);
    }
}

