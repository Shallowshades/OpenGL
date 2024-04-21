#version 330 core
in vec2 TexCoord;

uniform sampler2D texture1;
//uniform sampler2D texture2;
uniform float mixValue;

out vec4 FragColor;

void main()
{
    //FragColor = mix(texture(texture1, TexCoord), texture(texture2, TexCoord), mixValue);  
    FragColor = texture(texture1, TexCoord);  
}
