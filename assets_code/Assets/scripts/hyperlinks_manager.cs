using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hyperlinks_manager : MonoBehaviour
{
    public void OpenGithub()
    {
        Application.OpenURL("https://github.com/mortalcoder");
    }

    public void OpenTwitter()
    {
        Application.OpenURL("https://twitter.com/CoderMortal");
    }
}
