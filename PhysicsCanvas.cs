using Avalonia.Controls;
using Avalonia.Media;

// In C#, it's best practice to put your code into name spaces so that
// if someone else made a "PhysicsCanvas" then it wouldn't interfere with your definition of a PhysicsCanvas.
namespace Physics
{
    // All code in C# is writing within 'classes'.
    // A class is the definition of an object, what it can do, and all of its members.
    // This class seems rather boring, because it's getting all of it's behaviour from Canvas.
    // It's doing that using 'inheritance' (the ': Canvas' bit).
    // That is, PhysicsCanvas can do everything Canvas can do, and has every member that Canvas has.
    // This is a way for us to extend behaviour, rather than having to implement it from scratch.
    public class PhysicsCanvas : Canvas
    {
        // This is our only method in this class.
        // This method is called when the application wants to render the content of this canvas.
        public override void Render(DrawingContext context)
        {
            // For now, we'll just pass to the 'base' class that we inherited from (Canvas).
            base.Render(context);
        }
    }
}