
public enum HiraganaEnum
{
    あ,
    
    い,
    う,
    え,
    お,
    か,
    き,
    く,
    け,
    こ,
    さ,
    し,
    す,
    せ,
    そ,
    た,
    ち,
    つ,
    て,
    と,
    な,
    に,
    ぬ,
    ね,
    の,
    は,
    ひ,
    ふ,
    へ,
    ほ,
    ま,
    み,
    む,
    め,
    も,
    や,
    ゆ,
    よ,
    ら,
    り,
    る,
    れ,
    ろ,
    わ,
    を,
    ん
}

public enum HiraganaType
{
    NORMAL,
    TEN,
    MARU
}

public static class HiraganaHelper
{
    public static string ToText(this HiraganaEnum hiragana/*, HiraganaType type*/)
    {
                return hiragana.ToString();
    }
}
