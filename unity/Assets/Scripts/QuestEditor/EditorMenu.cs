﻿using UnityEngine;
using Assets.Scripts.Content;

// Menu popup when in editor
public class EditorMenu {

    private static readonly StringKey SAVE = new StringKey("val", "SAVE");
    private static readonly StringKey RELOAD = new StringKey("val", "RELOAD");
    private static readonly StringKey MAIN_MENU = new StringKey("val", "MAIN_MENU");

    public static void Create()
    {
        Game game = Game.Get();
        if (GameObject.FindGameObjectWithTag(Game.DIALOG) != null)
        {
            return;
        }

        // Menu border
        UIElement ui = new UIElement();
        ui.SetLocation((UIScaler.GetWidthUnits() - 12) / 2, 9, 12, 13);
        new UIElementBorder(ui);

        TextButton tb = new TextButton(
            new Vector2((UIScaler.GetWidthUnits() - 10) / 2, 10), new Vector2(10, 2f), 
            SAVE, delegate { QuestEditor.Save(); }, Color.white);
        tb.background.GetComponent<UnityEngine.UI.Image>().color = new Color(0.03f, 0.0f, 0f);
        tb.SetFont(game.gameType.GetHeaderFont());

        tb = new TextButton(
            new Vector2((UIScaler.GetWidthUnits() - 10) / 2, 13), new Vector2(10, 2f), 
            RELOAD, delegate { QuestEditor.Reload(); }, Color.white);
        tb.background.GetComponent<UnityEngine.UI.Image>().color = new Color(0.03f, 0.0f, 0f);
        tb.SetFont(game.gameType.GetHeaderFont());

        tb = new TextButton(
            new Vector2((UIScaler.GetWidthUnits() - 10) / 2, 16), new Vector2(10, 2f), 
            MAIN_MENU, delegate { Destroyer.MainMenu(); }, Color.white);
        tb.background.GetComponent<UnityEngine.UI.Image>().color = new Color(0.03f, 0.0f, 0f);
        tb.SetFont(game.gameType.GetHeaderFont());

        tb = new TextButton(
            new Vector2((UIScaler.GetWidthUnits() - 10) / 2, 19), new Vector2(10, 2f),
            CommonStringKeys.CANCEL, delegate { Destroyer.Dialog(); }, Color.white);
        tb.background.GetComponent<UnityEngine.UI.Image>().color = new Color(0.03f, 0.0f, 0f);
        tb.SetFont(game.gameType.GetHeaderFont());

    }
}
