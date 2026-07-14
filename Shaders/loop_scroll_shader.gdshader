shader_type canvas_item;

uniform vec2 scroll_dir;
uniform float scroll_speed;
varying vec4 modulate;

void vertex() {
	modulate = COLOR;
}

void fragment() {
	vec2 move = scroll_dir * TIME * scroll_speed;
	COLOR = texture(TEXTURE, UV+move) * modulate;
}