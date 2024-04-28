#version 330 core
layout (location = 0) in vec3 aPos;
layout (location = 1) in vec3 aNormal;

out vec3 FragPos;
out vec3 Normal;
out vec3 LightPos;

uniform vec3 lightPos;

uniform mat4 model;
uniform mat4 view;
uniform mat4 projection;

void main() {
    gl_Position = projection * view * model * vec4(aPos, 1.0);
    FragPos = vec3(view * model * vec4(aPos, 1.0));
    // 不能表达空间中的特定位置, 不等比缩放后法向量不在垂直于表面
    // 逆置矩阵和转置矩阵, 但矩阵求逆计算量很大, 建议使用CPU计算,使用uniform传递
    Normal = mat3(transpose(inverse(model))) * aNormal;
    LightPos = vec3(view * vec4(lightPos, 1.0));
}