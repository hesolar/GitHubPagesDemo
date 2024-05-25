using Microsoft.AspNetCore.Components;

namespace CV.Shared;

public static class Extensions
{

    public static RenderFragment StringToRenderFragament(this string content)
    {
        RenderFragment renderFragment = builder =>
        {
            builder.AddMarkupContent(0, content);
        };

        return renderFragment;
    }

       
    


}
