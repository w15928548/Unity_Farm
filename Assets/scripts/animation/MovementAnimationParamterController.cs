using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementAnimationParamterController : MonoBehaviour
{
    private Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    private void OnEnable()
    {
        EventHanlder.MovementEvent += SetAnimationParamters;
    }

    private void OnDisable()
    {
        EventHanlder.MovementEvent -= SetAnimationParamters;
    }

    private void SetAnimationParamters(float inputX, float inputY, bool isWalking, bool isRunning, bool isIdle, bool isCarrying,
        ToolEffect toolEffect,
        bool isUsingToolRight, bool isUsingToolLeft, bool isUsingToolUp, bool isUsingToolDown,
        bool isLiftingToolRight, bool isLiftingToolLeft, bool isLiftingToolUp, bool isLiftingToolDown,
        bool isPickingRight, bool isPickingLeft, bool isPickingUp, bool isPickingDown,
        bool isSwingingToolRight, bool isSwingingToolLeft, bool isSwingingToolUp, bool isSwingingToolDown,
        bool idleUp, bool idleDown, bool idleLeft, bool idleRight)
    {

        animator.SetFloat(Settings.xInput, inputX);
        animator.SetFloat(Settings.yInput, inputY);
        animator.SetBool(Settings.isWalking, isWalking);
        animator.SetBool(Settings.isRunning, isRunning);

        animator.SetInteger(Settings.toolEffect, (int)toolEffect);

        if (isUsingToolRight)
        {
            animator.SetTrigger(Settings.isUsingToolRight);
        }
        if (isUsingToolLeft)
        {
            animator.SetTrigger(Settings.isUsingToolLeft);
        }
        if (isUsingToolUp)
        {
            animator.SetTrigger(Settings.isUsingToolUp);
        }
        if (isUsingToolDown)
        {
            animator.SetTrigger(Settings.isUsingToolDown);
        }

        if (isLiftingToolRight)
        {
            animator.SetTrigger(Settings.isLiftingToolRight);
        }
        if (isLiftingToolLeft)
        {
            animator.SetTrigger(Settings.isLiftingToolLeft);
        }
        if (isLiftingToolUp)
        {
            animator.SetTrigger(Settings.isLiftingToolUp);
        }
        if (isLiftingToolDown)
        {
            animator.SetTrigger(Settings.isLiftingToolDown);
        }

        if (isSwingingToolRight)
        {
            animator.SetTrigger(Settings.isSwingingToolRight);
        }
        if (isSwingingToolLeft)
        {
            animator.SetTrigger(Settings.isSwingingToolLeft);
        }
        if (isSwingingToolDown)
        {
            animator.SetTrigger(Settings.isSwingingToolDown);
        }
        if (isSwingingToolUp)
        {
            animator.SetTrigger(Settings.isSwingingToolUp);
        }

        if (isPickingRight)
        {
            animator.SetTrigger(Settings.isPickingRight);
        }
        if (isPickingLeft)
        {
            animator.SetTrigger(Settings.isPickingLeft);
        }
        if (isPickingUp)
        {
            animator.SetTrigger(Settings.isPickingUp);
        }
        if (isPickingDown)
        {
            animator.SetTrigger(Settings.isPickingDown);
        }

        if (idleRight)
        {
            animator.SetTrigger(Settings.idleRight);
        }
        if (idleLeft)
        {
            animator.SetTrigger(Settings.idleLeft);
        }
        if (idleDown)
        {
            animator.SetTrigger(Settings.idleDown);
        }
        if (idleUp)
        {
            animator.SetTrigger(Settings.idleUp);
        }
    }
}
