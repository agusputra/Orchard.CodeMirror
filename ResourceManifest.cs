using Orchard.UI.Resources;

namespace CodeMirror
{
    public class ResourceManifest : IResourceManifestProvider
    {
        public void BuildManifests(ResourceManifestBuilder builder)
        {
            var manifest = builder.Add();

            manifest.DefineScript("CodeMirror").SetUrl("../bower_components/codemirror/lib/codemirror.js");
            manifest.DefineScript("CodeMirror_ModeXml").SetUrl("../bower_components/codemirror/mode/xml/xml.js");
            manifest.DefineScript("CodeMirror_ModeJs").SetUrl("../bower_components/codemirror/mode/javascript/javascript.js");
            manifest.DefineScript("CodeMirror_ModeCss").SetUrl("../bower_components/codemirror/mode/css/css.js");
            manifest.DefineScript("CodeMirror_ModeHtmlmixed").SetUrl("../bower_components/codemirror/mode/htmlmixed/htmlmixed.js");
            manifest.DefineScript("CodeMirror_AddonMatchbrackets").SetUrl("../bower_components/codemirror/addon/edit/matchbrackets.js");
            manifest.DefineScript("CodeMirror_AddonFullscreen").SetUrl("../bower_components/codemirror/addon/display/fullscreen.js");
            manifest.DefineScript("CodeMirror_AddonShowhint").SetUrl("../bower_components/codemirror/addon/hint/show-hint.js");
            manifest.DefineScript("CodeMirror_AddonXmlhint").SetUrl("../bower_components/codemirror/addon/hint/xml-hint.js");
            manifest.DefineScript("CodeMirror_AddonHtmlhint").SetUrl("../bower_components/codemirror/addon/hint/html-hint.js");
            manifest.DefineScript("CodeMirror_AddonCsshint").SetUrl("../bower_components/codemirror/addon/hint/css-hint.js");
            manifest.DefineScript("CodeMirror_AddonJshint").SetUrl("../bower_components/codemirror/addon/hint/javascript-hint.js");

            manifest.DefineScript("OrchardCodeMirror").SetUrl("orchard-codemirror.js").SetDependencies("jQuery", "jQueryUi");
        }
    }
}
