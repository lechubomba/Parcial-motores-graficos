using System.Collections;
using System.Collections.Generic;
using UnityEngine;




private CharacterControler_enemyAI;
private Player_playerScript;


void start();
{
    _enemyAI = GetComponent<CharacterController>();
    _playerScript = GameObject.FindGameObjectWithTag("player").GetComponent<Player>();
    if (enemy_AI == null)
        Debug.Log.Error("enemy Script is Null");


            if (_playerScript == null)
        Debug.LogError("Player Script is Null");


}
Vector3 direction = _playerScript.transform.position - transform.position;
Vector3 velocity = direction * _speed;
float _gravity = _gravityValue * _gravityMultiplier * Time.deltaTime;

if (_enemy_AI.isGrounded)
{



}
else
{
    _enemiesYVelocity -= _gravity;


}
velocity.y = _enemies.YVelocity;
velocity.Normalize();
transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(velocity), _speed * Time.deltatime);
_enemyAI.Move(velocity * Time.DeltaTime);