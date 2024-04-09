#version 330 core
in vec3 ourColor;
in vec2 TexCoord;

uniform sampler2D texture1;
uniform sampler2D texture2;
uniform float mixValue;

out vec4 FragColor;

void main()
{
    //FragColor = texture(ourTexture, TexCoord);
    //FragColor = texture(ourTexture, TexCoord) * vec4(ourColor, 1.0);
    //FragColor = mix(texture(texture1, TexCoord), texture(texture2, TexCoord), 0.2);
    FragColor = mix(texture(texture1, TexCoord), texture(texture2, TexCoord), mixValue);
    //FragColor = mix(texture(texture1, TexCoord), texture(texture2, vec2(-TexCoord.x, TexCoord.y)), 0.2); // 水平反转
    //FragColor = mix(texture(texture1, TexCoord), texture(texture2, vec2(1.0f - TexCoord.x, TexCoord.y)), 0.2);     
}
