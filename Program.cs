// See https://aka.ms/new-console-template for more information

using DesignPatternsDemo.Patterns;
using DesignPatternsDemo.Patterns.Structural;

VideoEditor videoEditor = new VideoEditor(new Video());
videoEditor.Edit(new BlackAndWhite());
videoEditor.Edit(new BlueTheme());
videoEditor.Edit(new ThirdPartyAdapter(new SomeThirdPartyLib()));   