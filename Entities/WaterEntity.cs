﻿using UnityEngine;
using System.Collections;

public class WaterEntity : Entity
{
    private BoxCollider2D thisCollider;

    void Start()
    {
        thisCollider = GetComponent<BoxCollider2D>();
    }

	override public void OnBodyCollisionEnter()
	{
        collidedWithBody = true;
		Messenger.Broadcast<string, Collider2D, int>("player dead", "drowned", thisCollider, 0);

	}

	override public void OnBodyCollisionStay() {}
	override public void OnBodyCollisionExit() {}
    override public void OnWeaponCollisionEnter() {}
    override public void OnWeaponCollisionStay() {}
    override public void OnWeaponCollisionExit() {}
}
