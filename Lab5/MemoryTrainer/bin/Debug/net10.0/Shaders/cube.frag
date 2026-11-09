#version 330 core
out vec4 FragColor;

in vec3 FragPos;
in vec3 Normal;
in vec2 TexCoord;

uniform vec3 lightPos;
uniform vec3 viewPos;
uniform sampler2D tex;
uniform int isBack;

void main()
{
    // Ambient
    float ambientStrength = 0.5;
    vec3 ambient = ambientStrength * vec3(1.0);
    
    // Diffuse
    vec3 norm = normalize(Normal);
    vec3 lightDir = normalize(lightPos - FragPos);
    float diff = max(dot(norm, lightDir), 0.0);
    vec3 diffuse = diff * vec3(1.0);
    
    // Combine
    vec3 lighting = ambient + diffuse;
    
    // Texture with optional flip for back face
    vec2 uv = TexCoord;
    if (isBack == 1)
        uv.y = 1.0 - uv.y;
    
    FragColor = texture(tex, uv) * vec4(lighting, 1.0);
}