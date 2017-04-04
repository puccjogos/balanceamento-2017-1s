﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ArcadePUCCampinas
{
    public class ArcadeJogo : Singleton<ArcadeJogo>
    {
        void Awake()
        {
            InputArcade.Inicializar();
            Screen.fullScreen = true;
            Cursor.visible = false;
            Application.runInBackground = true;
        }

        void Update()
        {
            if (InputArcade.Apertou(0, EControle.MENU))
            {
                Application.Quit();
            }
        }

        void LateUpdate()
        {
            InputArcade.Atualizar();
        }
    }
}