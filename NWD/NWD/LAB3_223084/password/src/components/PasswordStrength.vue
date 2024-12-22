<template>
  <h1>Vue Password Strength Indicator</h1>
  <label class="frmLabel" for="email">Email</label>
  <input placeholder="Enter your email" name="email" id="email" class="frmField" type="email" @input="email" v-model="email" />
  <label class="frmLabel" for="password">Password</label>
  <input placeholder="Enter your password" name="password" id="password" class="frmField" type="password" @input="password" v-model="password" />
  <p class="frmValidation" :class="{'frmValidation--passed' : password.length > 7}">
    <i class="frmIcon fas" :class="password.length > 7 ? 'fa-check' : 'fa-times'"></i>
    Longer than 7 characters
  </p>
  <p class="frmValidation" :class="{'frmValidation--passed' :hasUppercase }">
    <i class="frmIcon fas" :class="hasUppercase ? 'fa-check' : 'fa-times'"></i>
    Has a capital letter
  </p>
  <p class="frmValidation" :class="{'frmValidation--passed' :hasLowercase }">
    <i class="frmIcon fas" :class="hasLowercase ? 'fa-check' : 'fa-times'"></i>
    Has a lowercase letter
  </p>
  <p class="frmValidation" :class="{'frmValidation--passed' : hasNumber }">
    <i class="frmIcon fas" :class="hasNumber ? 'fa-check' : 'fa-times'"></i>
    Has a number
  </p>
  <p class="frmValidation" :class="{'frmValidation--passed' : hasSpecial }">
    <i class="frmIcon fas" :class="hasSpecial ? 'fa-check' : 'fa-times'"></i>
    Has a special character
  </p>
  <p class="frmValidation" :class="{'frmValidation--passed' : isEmail }">
    <i class="frmIcon fas" :class="isEmail ? 'fa-check' : 'fa-times'"></i>
    Is a valid email address.
  </p>

  <p>Email: {{email}}</p>
  <p>Password: {{ password }}</p>

</template>

<script>
export default {
  name: "PasswordStrength",
  data() {
    return {
      password: "",
      email: "",
    };
  },
  computed: {
    hasUppercase() {
      return /[A-Z]/.test(this.password);
    },
    hasLowercase() {
      return /[a-z]/.test(this.password)
    },
    hasNumber() {
      return /[0-9]/.test(this.password);
    },
    hasSpecial() {
      return /[!@#$%^&*(),.?":{}|<>]/.test(this.password);
    },
    isEmail() {
      return /^[a-zA-Z_.][a-zA-Z_.0-9]+@[^@]+$/.test(this.email);
    }
  },

}
</script>







