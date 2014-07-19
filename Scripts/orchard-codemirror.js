jQuery(function () {
    CodeMirror.fromTextArea(document.getElementById("codeMirrorTextArea"), {
        lineNumbers: true,
        lineWrapping: true,
        mode: "htmlmixed",
        matchBrackets: true,
        extraKeys: {
            "F11": function (cm) {
                cm.setOption("fullScreen", !cm.getOption("fullScreen"));
            },
            "Esc": function (cm) {
                if (cm.getOption("fullScreen")) cm.setOption("fullScreen", false);
            },
            "Ctrl-Space": "autocomplete"
        }
    });

    $(".CodeMirror").resizable({
        resize: function () {
            editor.setSize($(this).width(), $(this).height());
        }
    });
});