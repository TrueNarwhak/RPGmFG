extends Control

@export var disclaimer_label: RichTextLabel 
@export var anim_player: AnimationPlayer 

@export var can_progress: bool = false

func _ready() -> void:
	anim_player.play("reveal")

func _process(delta: float) -> void:
	if Input.is_action_just_pressed("ui_accept"):
		pass
