# 🔒 Password Strength Evaluation & Security Best Practices - Task 6

## 🚀 Overview

This project demonstrates how to create, evaluate, and manage strong passwords, with a focus on modern security practices such as password managers, multi-factor authentication (MFA), and passwordless technologies. It includes hands-on password strength testing, actionable tips, and guidance for securing your digital life.

---

## 🎯 Objectives

- Learn what makes a password strong.
- Test password strength using online tools.
- Summarize best practices for password creation & management.
- Explore advanced security features like MFA and passkeys.

---

## 🧪 Password Samples & Strength Evaluation

Tested using [Security.org](https://www.security.org/how-secure-is-my-password/) and [Bitwarden.com](https://bitwarden.com/password-strength/)

| Password Example         | Description                         | Strength      | Estimated Crack Time   | Feedback                                   |
|-------------------------|-------------------------------------|---------------|-----------------------|---------------------------------------------|
| password123             | Simple, lowercase + numbers         | 🔴 Very Weak  | < 1 second            | Common, easily guessed, in breach databases |
| Password123             | Mixed case + numbers                | 🟠 Weak       | Few seconds           | Predictable pattern, common substitution    |
| P@ssw0rd!               | Mixed case, numbers, symbols        | 🟡 Moderate   | 3 days                | Substitution known, not unique enough       |
| Cat4food@Catster        | Secure format, all character types  | 🟢 Strong     | Years                 | Good mix, unique, not a dictionary word     |
| P@ssw0rd!2025           | Mixed case, numbers, symbols, longer| 🟢 Strong     | Months to years       | Better, still uses common patterns          |
| P@66w0rd!Longer2001     | Complex, long, all character types  | 🟢 Excellent  |  years                | Long, complex, unique, all character types  |

---

## 🏆 Best Practices for Secured Passwords

- **Length:** Use at least 12–16 characters; longer is better! 
- **Complexity:** Mix uppercase, lowercase, numbers, and symbols.
- **Unpredictability:** Avoid dictionary words, names, or common phrases.
- **Uniqueness:** Never reuse passwords across websites. 
- **Password Managers:** Use tools like **Bitwarden** or **KeePass** to generate and store strong, unique passwords.
- **Avoid Browser Autofill:** Not recommended for sensitive accounts; password managers are safer. 
- **Categorize Passwords:**
  - **Mail & Finance:** Use the strongest passwords, change every 120 days.
  - **Temporary Sites:** Use less critical passwords, but never reuse important ones.
- **Update Regularly:** Change passwords for sensitive accounts every few months. 

---

## 🛡️ Multi-Factor Authentication (MFA/2FA)

- **Why MFA?**  
  MFA adds an extra layer of protection, blocking 99.9% of automated attacks—even if your password is compromised.
- **How to Enable:**  
  - Turn on 2FA for all critical accounts (email, banking, social media).
  - Use authenticator apps (e.g., Google Authenticator, Microsoft Authenticator) for OTP logins. 
- **Passwordless & Passkeys:**  
  - **Microsoft:** All new accounts are passwordless by default; enable passkey sign-in for near-total protection. 
  - **Google:** Enable passkeys for device-based biometric/PIN authentication. 
    - [Enable Google Passkey](https://www.google.com/account/about/passkeys/)

---

## 🔑 Password Security Tips & Insights

- **Avoid using the same password everywhere.**
- **Never use personal info (name, birthday, etc.).**
- **Consider passphrases:** Combine 4–7 unrelated words (e.g., `HorsePurpleHatRunBay`). 
- **Password managers** encrypt your credentials and help you organize them securely.
- **MFA/2FA** is essential for all important accounts.
- **Passkeys** and passwordless sign-in options are the future of authentication—enable them wherever possible. 

---

## 🚨 Common Password Attacks & Defenses

| Attack Type         | Description                                   | Defense                                      |
|---------------------|-----------------------------------------------|----------------------------------------------|
| Brute Force         | Tries all possible combinations               | Long, complex passwords                      |
| Dictionary Attack   | Uses common words/phrases                     | Avoid dictionary words & common substitutions|
| Credential Stuffing | Uses leaked password pairs                    | Unique passwords for every account           |
| Password Spraying   | Tries common passwords across many accounts   | Avoid common passwords                       |
| Keylogger           | Captures keystrokes                           | Use security software, avoid suspicious links|
| Rainbow Table       | Precomputed hash tables                       | Use strong, salted hashes (for admins)       |

---


> **Stay safe online! Use strong, unique passwords, enable MFA, and embrace passwordless technology for the best security.** 🛡️🔐
