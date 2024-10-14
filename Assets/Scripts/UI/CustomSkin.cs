using System.IO;
using UnityEngine;

public class CustomSkin : MonoBehaviour
{
    public Sprite Tap;
    public Sprite Tap_Each;
    public Sprite Tap_Break;
    public Sprite Tap_Ex;

    public Sprite Slide;
    public Sprite Slide_Each;
    public Sprite Slide_Break;
    public Sprite[] Wifi = new Sprite[11];
    public Sprite[] Wifi_Each = new Sprite[11];
    public Sprite[] Wifi_Break = new Sprite[11];

    public Sprite Star;
    public Sprite Star_Double;
    public Sprite Star_Each;
    public Sprite Star_Each_Double;
    public Sprite Star_Break;
    public Sprite Star_Break_Double;
    public Sprite Star_Ex;
    public Sprite Star_Ex_Double;

    public Sprite Hold;
    public Sprite Hold_On;
    public Sprite Hold_Off;
    public Sprite Hold_Each;
    public Sprite Hold_Each_On;
    public Sprite Hold_Ex;
    public Sprite Hold_Break;
    public Sprite Hold_Break_On;

    public Sprite[] Just = new Sprite[36];
    public Sprite[] JudgeText = new Sprite[5];
    public Sprite JudgeText_Break;
    public Sprite FastText;
    public Sprite LateText;

    public Sprite Touch;
    public Sprite Touch_Each;
    public Sprite TouchPoint;
    public Sprite TouchPoint_Each;
    public Sprite TouchJust;
    public Sprite[] TouchBorder = new Sprite[2];
    public Sprite[] TouchBorder_Each = new Sprite[2];

    public Sprite[] TouchHold = new Sprite[5];

    public Texture2D test;
    private SpriteRenderer Outline;

    private void loadInternal()
    {
        Outline = gameObject.GetComponent<SpriteRenderer>();
        Outline.sprite = Resources.Load<Sprite>("Skin/outline");

        Tap = Resources.Load<Sprite>("Skin/tap");
        Tap_Each = Resources.Load<Sprite>("Skin/tap_each");
        Tap_Break = Resources.Load<Sprite>("Skin/tap_break");
        Tap_Ex = Resources.Load<Sprite>("Skin/tap_ex");

        Slide = Resources.Load<Sprite>("Skin/slide");
        Slide_Each = Resources.Load<Sprite>("Skin/slide_each");
        Slide_Break = Resources.Load<Sprite>("Skin/slide_break");
        for (var i = 0; i < 11; i++)
        {
            Wifi[i] = Resources.Load<Sprite>("Skin/wifi_" + i + "");
            Wifi_Each[i] = Resources.Load<Sprite>("Skin/wifi_each_" + i + "");
            Wifi_Break[i] = Resources.Load<Sprite>("Skin/wifi_break_" + i + "");
        }

        Star = Resources.Load<Sprite>("Skin/star");
        Star_Double = Resources.Load<Sprite>("Skin/star_double");
        Star_Each = Resources.Load<Sprite>("Skin/star_each");
        Star_Each_Double = Resources.Load<Sprite>("Skin/star_each_double");
        Star_Break = Resources.Load<Sprite>("Skin/star_break");
        Star_Break_Double = Resources.Load<Sprite>("Skin/star_break_double");
        Star_Ex = Resources.Load<Sprite>("Skin/star_ex");
        Star_Ex_Double = Resources.Load<Sprite>("Skin/star_ex_double");

        Hold = Resources.Load<Sprite>("Skin/hold");        
        Hold_Each = Resources.Load<Sprite>("Skin/hold_each");
        Hold_Each_On = Resources.Load<Sprite>("Skin/hold_each_on");
        Hold_Ex = Resources.Load<Sprite>("Skin/hold_ex");
        Hold_Break = Resources.Load<Sprite>("Skin/hold_break");
        Hold_Break_On = Resources.Load<Sprite>("Skin/hold_break_on");
        Hold_On = Resources.Load<Sprite>("Skin/hold_on");
        Hold_Off = Resources.Load<Sprite>("Skin/hold_off");


        Just[0] = Resources.Load<Sprite>("Skin/just_curv_r");
        Just[1] = Resources.Load<Sprite>("Skin/just_str_r");
        Just[2] = Resources.Load<Sprite>("Skin/just_wifi_u");
        Just[3] = Resources.Load<Sprite>("Skin/just_curv_l");
        Just[4] = Resources.Load<Sprite>("Skin/just_str_l");
        Just[5] = Resources.Load<Sprite>("Skin/just_wifi_d");

        Just[6] = Resources.Load<Sprite>("Skin/just_curv_r_fast_gr");
        Just[7] = Resources.Load<Sprite>("Skin/just_str_r_fast_gr");
        Just[8] = Resources.Load<Sprite>("Skin/just_wifi_u_fast_gr");
        Just[9] = Resources.Load<Sprite>("Skin/just_curv_l_fast_gr");
        Just[10] = Resources.Load<Sprite>("Skin/just_str_l_fast_gr");
        Just[11] = Resources.Load<Sprite>("Skin/just_wifi_d_fast_gr");

        Just[12] = Resources.Load<Sprite>("Skin/just_curv_r_fast_gd");
        Just[13] = Resources.Load<Sprite>("Skin/just_str_r_fast_gd");
        Just[14] = Resources.Load<Sprite>("Skin/just_wifi_u_fast_gd");
        Just[15] = Resources.Load<Sprite>("Skin/just_curv_l_fast_gd");
        Just[16] = Resources.Load<Sprite>("Skin/just_str_l_fast_gd");
        Just[17] = Resources.Load<Sprite>("Skin/just_wifi_d_fast_gd");

        Just[18] = Resources.Load<Sprite>("Skin/just_curv_r_late_gr");
        Just[19] = Resources.Load<Sprite>("Skin/just_str_r_late_gr");
        Just[20] = Resources.Load<Sprite>("Skin/just_wifi_u_late_gr");
        Just[21] = Resources.Load<Sprite>("Skin/just_curv_l_late_gr");
        Just[22] = Resources.Load<Sprite>("Skin/just_str_l_late_gr");
        Just[23] = Resources.Load<Sprite>("Skin/just_wifi_d_late_gr");

        Just[24] = Resources.Load<Sprite>("Skin/just_curv_r_late_gd");
        Just[25] = Resources.Load<Sprite>("Skin/just_str_r_late_gd");
        Just[26] = Resources.Load<Sprite>("Skin/just_wifi_u_late_gd");
        Just[27] = Resources.Load<Sprite>("Skin/just_curv_l_late_gd");
        Just[28] = Resources.Load<Sprite>("Skin/just_str_l_late_gd");
        Just[29] = Resources.Load<Sprite>("Skin/just_wifi_d_late_gd");

        Just[30] = Resources.Load<Sprite>("Skin/miss_curv_r");
        Just[31] = Resources.Load<Sprite>("Skin/miss_str_r");
        Just[32] = Resources.Load<Sprite>("Skin/miss_wifi_u");
        Just[33] = Resources.Load<Sprite>("Skin/miss_curv_l");
        Just[34] = Resources.Load<Sprite>("Skin/miss_str_l");
        Just[35] = Resources.Load<Sprite>("Skin/miss_wifi_d");

        JudgeText[0] = Resources.Load<Sprite>("Skin/judge_text_miss");
        JudgeText[1] = Resources.Load<Sprite>("Skin/judge_text_good");
        JudgeText[2] = Resources.Load<Sprite>("Skin/judge_text_great");
        JudgeText[3] = Resources.Load<Sprite>("Skin/judge_text_perfect");
        JudgeText[4] = Resources.Load<Sprite>("Skin/judge_text_cPerfect");
        JudgeText_Break = Resources.Load<Sprite>("Skin/judge_text_break");

        FastText = Resources.Load<Sprite>("Skin/fast");
        LateText = Resources.Load<Sprite>("Skin/late");

        Touch = Resources.Load<Sprite>("Skin/touch");
        Touch_Each = Resources.Load<Sprite>("Skin/touch_each");
        TouchPoint = Resources.Load<Sprite>("Skin/touch_point");
        TouchPoint_Each = Resources.Load<Sprite>("Skin/touch_point_each");

        TouchJust = Resources.Load<Sprite>("Skin/touch_just");

        TouchBorder[0] = Resources.Load<Sprite>("Skin/touch_border_2");
        TouchBorder[1] = Resources.Load<Sprite>("Skin/touch_border_3");
        TouchBorder_Each[0] = Resources.Load<Sprite>("Skin/touch_border_2_each");
        TouchBorder_Each[1] = Resources.Load<Sprite>("Skin/touch_border_3_each");

        for (var i = 0; i < 4; i++) TouchHold[i] = Resources.Load<Sprite>("Skin/touchhold_" + i + "");
        TouchHold[4] = Resources.Load<Sprite>("Skin/touchhold_border");
    }
    
    private void loadExternal(string path)
    {
        Outline = gameObject.GetComponent<SpriteRenderer>();
        print(path);

        Outline.sprite = SpriteLoader.LoadSpriteFromFile(path + "/outline.png");

        Tap = SpriteLoader.LoadSpriteFromFile(path + "/tap.png");
        Tap_Each = SpriteLoader.LoadSpriteFromFile(path + "/tap_each.png");
        Tap_Break = SpriteLoader.LoadSpriteFromFile(path + "/tap_break.png");
        Tap_Ex = SpriteLoader.LoadSpriteFromFile(path + "/tap_ex.png");

        Slide = SpriteLoader.LoadSpriteFromFile(path + "/slide.png");
        Slide_Each = SpriteLoader.LoadSpriteFromFile(path + "/slide_each.png");
        Slide_Break = SpriteLoader.LoadSpriteFromFile(path + "/slide_break.png");
        for (var i = 0; i < 11; i++)
        {
            Wifi[i] = SpriteLoader.LoadSpriteFromFile(path + "/wifi_" + i + ".png");
            Wifi_Each[i] = SpriteLoader.LoadSpriteFromFile(path + "/wifi_each_" + i + ".png");
            Wifi_Break[i] = SpriteLoader.LoadSpriteFromFile(path + "/wifi_break_" + i + ".png");
        }

        Star = SpriteLoader.LoadSpriteFromFile(path + "/star.png");
        Star_Double = SpriteLoader.LoadSpriteFromFile(path + "/star_double.png");
        Star_Each = SpriteLoader.LoadSpriteFromFile(path + "/star_each.png");
        Star_Each_Double = SpriteLoader.LoadSpriteFromFile(path + "/star_each_double.png");
        Star_Break = SpriteLoader.LoadSpriteFromFile(path + "/star_break.png");
        Star_Break_Double = SpriteLoader.LoadSpriteFromFile(path + "/star_break_double.png");
        Star_Ex = SpriteLoader.LoadSpriteFromFile(path + "/star_ex.png");
        Star_Ex_Double = SpriteLoader.LoadSpriteFromFile(path + "/star_ex_double.png");

        var border = new Vector4(0, 58, 0, 58);
        Hold = SpriteLoader.LoadSpriteFromFile(path + "/hold.png", border);        
        Hold_Each = SpriteLoader.LoadSpriteFromFile(path + "/hold_each.png", border);
        Hold_Each_On = SpriteLoader.LoadSpriteFromFile(path + "/hold_each_on.png", border);
        Hold_Ex = SpriteLoader.LoadSpriteFromFile(path + "/hold_ex.png", border);
        Hold_Break = SpriteLoader.LoadSpriteFromFile(path + "/hold_break.png", border);
        Hold_Break_On = SpriteLoader.LoadSpriteFromFile(path + "/hold_break_on.png", border);

        if (File.Exists(Path.Combine(path, "hold_on.png")))
            Hold_On = SpriteLoader.LoadSpriteFromFile(path + "/hold_on.png", border);
        else
            Hold_On = Hold;
        Hold_Off = SpriteLoader.LoadSpriteFromFile(path + "/hold_off.png", border);
        if (File.Exists(Path.Combine(path, "hold_each_on.png")))
            Hold_Each_On = SpriteLoader.LoadSpriteFromFile(path + "/hold_each_on.png", border);
        else
            Hold_Each_On = Hold_Each;

        if (File.Exists(Path.Combine(path, "hold_break_on.png")))
            Hold_Break_On = SpriteLoader.LoadSpriteFromFile(path + "/hold_break_on.png", border);
        else
            Hold_Break_On = Hold_Break;

        Just[0] = SpriteLoader.LoadSpriteFromFile(path + "/just_curv_r.png");
        Just[1] = SpriteLoader.LoadSpriteFromFile(path + "/just_str_r.png");
        Just[2] = SpriteLoader.LoadSpriteFromFile(path + "/just_wifi_u.png");
        Just[3] = SpriteLoader.LoadSpriteFromFile(path + "/just_curv_l.png");
        Just[4] = SpriteLoader.LoadSpriteFromFile(path + "/just_str_l.png");
        Just[5] = SpriteLoader.LoadSpriteFromFile(path + "/just_wifi_d.png");

        Just[6] = SpriteLoader.LoadSpriteFromFile(path + "/just_curv_r_fast_gr.png");
        Just[7] = SpriteLoader.LoadSpriteFromFile(path + "/just_str_r_fast_gr.png");
        Just[8] = SpriteLoader.LoadSpriteFromFile(path + "/just_wifi_u_fast_gr.png");
        Just[9] = SpriteLoader.LoadSpriteFromFile(path + "/just_curv_l_fast_gr.png");
        Just[10] = SpriteLoader.LoadSpriteFromFile(path + "/just_str_l_fast_gr.png");
        Just[11] = SpriteLoader.LoadSpriteFromFile(path + "/just_wifi_d_fast_gr.png");

        Just[12] = SpriteLoader.LoadSpriteFromFile(path + "/just_curv_r_fast_gd.png");
        Just[13] = SpriteLoader.LoadSpriteFromFile(path + "/just_str_r_fast_gd.png");
        Just[14] = SpriteLoader.LoadSpriteFromFile(path + "/just_wifi_u_fast_gd.png");
        Just[15] = SpriteLoader.LoadSpriteFromFile(path + "/just_curv_l_fast_gd.png");
        Just[16] = SpriteLoader.LoadSpriteFromFile(path + "/just_str_l_fast_gd.png");
        Just[17] = SpriteLoader.LoadSpriteFromFile(path + "/just_wifi_d_fast_gd.png");

        Just[18] = SpriteLoader.LoadSpriteFromFile(path + "/just_curv_r_late_gr.png");
        Just[19] = SpriteLoader.LoadSpriteFromFile(path + "/just_str_r_late_gr.png");
        Just[20] = SpriteLoader.LoadSpriteFromFile(path + "/just_wifi_u_late_gr.png");
        Just[21] = SpriteLoader.LoadSpriteFromFile(path + "/just_curv_l_late_gr.png");
        Just[22] = SpriteLoader.LoadSpriteFromFile(path + "/just_str_l_late_gr.png");
        Just[23] = SpriteLoader.LoadSpriteFromFile(path + "/just_wifi_d_late_gr.png");

        Just[24] = SpriteLoader.LoadSpriteFromFile(path + "/just_curv_r_late_gd.png");
        Just[25] = SpriteLoader.LoadSpriteFromFile(path + "/just_str_r_late_gd.png");
        Just[26] = SpriteLoader.LoadSpriteFromFile(path + "/just_wifi_u_late_gd.png");
        Just[27] = SpriteLoader.LoadSpriteFromFile(path + "/just_curv_l_late_gd.png");
        Just[28] = SpriteLoader.LoadSpriteFromFile(path + "/just_str_l_late_gd.png");
        Just[29] = SpriteLoader.LoadSpriteFromFile(path + "/just_wifi_d_late_gd.png");

        Just[30] = SpriteLoader.LoadSpriteFromFile(path + "/miss_curv_r.png");
        Just[31] = SpriteLoader.LoadSpriteFromFile(path + "/miss_str_r.png");
        Just[32] = SpriteLoader.LoadSpriteFromFile(path + "/miss_wifi_u.png");
        Just[33] = SpriteLoader.LoadSpriteFromFile(path + "/miss_curv_l.png");
        Just[34] = SpriteLoader.LoadSpriteFromFile(path + "/miss_str_l.png");
        Just[35] = SpriteLoader.LoadSpriteFromFile(path + "/miss_wifi_d.png");

        JudgeText[0] = SpriteLoader.LoadSpriteFromFile(path + "/judge_text_miss.png");
        JudgeText[1] = SpriteLoader.LoadSpriteFromFile(path + "/judge_text_good.png");
        JudgeText[2] = SpriteLoader.LoadSpriteFromFile(path + "/judge_text_great.png");
        JudgeText[3] = SpriteLoader.LoadSpriteFromFile(path + "/judge_text_perfect.png");
        JudgeText[4] = SpriteLoader.LoadSpriteFromFile(path + "/judge_text_cPerfect.png");
        JudgeText_Break = SpriteLoader.LoadSpriteFromFile(path + "/judge_text_break.png");

        FastText = SpriteLoader.LoadSpriteFromFile(path + "/fast.png");
        LateText = SpriteLoader.LoadSpriteFromFile(path + "/late.png");

        Touch = SpriteLoader.LoadSpriteFromFile(path + "/touch.png");
        Touch_Each = SpriteLoader.LoadSpriteFromFile(path + "/touch_each.png");
        TouchPoint = SpriteLoader.LoadSpriteFromFile(path + "/touch_point.png");
        TouchPoint_Each = SpriteLoader.LoadSpriteFromFile(path + "/touch_point_each.png");

        TouchJust = SpriteLoader.LoadSpriteFromFile(path + "/touch_just.png");

        TouchBorder[0] = SpriteLoader.LoadSpriteFromFile(path + "/touch_border_2.png");
        TouchBorder[1] = SpriteLoader.LoadSpriteFromFile(path + "/touch_border_3.png");
        TouchBorder_Each[0] = SpriteLoader.LoadSpriteFromFile(path + "/touch_border_2_each.png");
        TouchBorder_Each[1] = SpriteLoader.LoadSpriteFromFile(path + "/touch_border_3_each.png");

        for (var i = 0; i < 4; i++) TouchHold[i] = SpriteLoader.LoadSpriteFromFile(path + "/touchhold_" + i + ".png");
        TouchHold[4] = SpriteLoader.LoadSpriteFromFile(path + "/touchhold_border.png");

        Debug.Log(test);
    }
    
    // Start is called before the first frame update
    private void Start()
    {
        loadInternal();

        // 检验是否存在外部目录

        var path = new DirectoryInfo(Application.dataPath).Parent.FullName + "/Skin";
        Debug.Log(path);
        // 测试文件是否存在
        Debug.Log(File.Exists(path + "/tap.png"));
        if (File.Exists(path + "/tap.png"))
        {
            loadExternal(path);
        }
    }

    // Update is called once per frame
    private void Update()
    {
    }
}