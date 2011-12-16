def paradox():
  try:
    return True
  finally:
    return False

print paradox()
